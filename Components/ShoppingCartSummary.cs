using Microsoft.AspNetCore.Mvc;
using NintendoStore.Models;
using NintendoStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Components
{
    public class ShoppingCartSummary : ViewComponent
    {

        //bring in instance of shopping cart class
        private readonly ShoppingCart _shoppingCart;

        // inject into constructor to bring shopping cart into this compenent
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        // invoke method, logic for compenent that happens automatically
        public IViewComponentResult Invoke()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
