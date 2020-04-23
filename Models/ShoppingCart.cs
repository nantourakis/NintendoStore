using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class ShoppingCart
    {
        //bring in database data
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // Static Method to return Shopping Cart
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            //pass the servies collection to give us access to services and to create a Session to save data
            // ? is a null check and returns null if is null, if not then return Session
            ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            // check for active session, if not there then create a new id and convert to string like in our model
            // ?? if check for null, if session has a cart id then assign it, if null then provide a new one to CartId
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            //now we set the string session and pass in value from cartId
            session.SetString("CartId", cartId);

            // return new instance of shopping cart
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        //Add item to cart, pass in the Game and the amount
        public void AddToCart(Game game, int amount)
        {
            // retrieve - check if game id exist and if matches to the game id being passed in / same check with shopping cart item
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Game.GameId == game.GameId && s.ShoppingCartId == ShoppingCartId);

            // check if shopping cart item is null, if so then create new shopping cart item and assign its properties
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Game = game,
                    Amount = amount
                };

                //add to db context
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }

            // else if not null then we need to increment the amount of the same game to the cart
            else
            {
                shoppingCartItem.Amount++;
            }

            _appDbContext.SaveChanges();

        }

            //remove items from the cart
            //pass in the game you want to remove from the cart
            //1st check if game exists
            public int RemoveFromCart(Game game)
            {
                var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Game.GameId == game.GameId && s.ShoppingCartId == ShoppingCartId);

                var localAmount = 0;

                if (shoppingCartItem != null)
                {
                    if (shoppingCartItem.Amount > 1)
                    {
                        shoppingCartItem.Amount--;
                        localAmount = shoppingCartItem.Amount;
                    }
                    else
                    {
                        _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                    }
                }

                _appDbContext.SaveChanges();

                return localAmount;
            }
        
            // get all items in the cart
            public List<ShoppingCartItem> GetShoppingCartItems()
            {
            // ?? = if null then return null otherwise return shopping cart items from the db context
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where
            (c => c.ShoppingCartId == ShoppingCartId)
            .Include(s => s.Game)
            .ToList());
            }

        //clear the shopping cart
        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        // calculate amount for our order
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Game.Price * c.Amount).Sum();

            return total;
        }
        //add shopping cart to our services
    }
}
