using Microsoft.AspNetCore.Mvc;
using NintendoStore.Models;
using NintendoStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        //in the controller, bring in the repository and models so we can work with them
        private readonly IGameRepository _gameRepository;
        private readonly ShoppingCart _shoppingCart;

        //inject into constructor 
        public ShoppingCartController(IGameRepository gameRepository, ShoppingCart shoppingCart)
        {
            _gameRepository = gameRepository;

            _shoppingCart = shoppingCart;
        }


        // create action that returns card and total amount of cart
        public ViewResult Index()
        {
            //retrieve the items and set within shopping cart
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //combine items and total amount, create the view model
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        //Action that items to the shopping cart, display updated cart
        public RedirectToActionResult AddToShoppingCart(int gameId)
        {
            //get game id and check if it matches
            var selectedGame = _gameRepository.GetAllGames.FirstOrDefault(c => c.GameId == gameId);
            
            if (selectedGame != null)
            {
                // if selected game isnt null then add to shopping cart
                _shoppingCart.AddToCart(selectedGame, 1);
            }

            //redirect to this controller
            return RedirectToAction("Index");
        }

        //Action that removes game from the cart
        public RedirectToActionResult RemoveFromShoppingCart(int gameId)
        {
            //get game id and check if it matches
            var selectedGame = _gameRepository.GetAllGames.FirstOrDefault(c => c.GameId == gameId);

            if (selectedGame != null)
            {
                // if selected game isnt null then remove from shopping cart
                _shoppingCart.RemoveFromCart(selectedGame);
            }

            //redirect to this controller
            return RedirectToAction("Index");
        }

        //Action that clears the cart completely, redirect to stay on same page. ClearCart is the action
        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }

    }
}
