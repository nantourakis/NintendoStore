using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class OrderRepository : IOrderRepository
    {

        // bring in db dontext to work with database and shopping cart since order comes from here
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        // inject into constructor so we can use
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            // create order detail and give id
            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach(var shoppingCartItem in shoppingCartItems)
            {
                // create new instance of Order Detail
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Game.Price,
                    GameId = shoppingCartItem.Game.GameId,
                    OrderId = order.OrderID
                };

                //add to context
                _appDbContext.OrderDetails.Add(orderDetail);
            }

            //now save changes to db
            _appDbContext.SaveChanges();
        }
    }
}
