using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NintendoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Controllers
{
    //restric access to the login user only on the whole controller. needs to be logged in to place order
    [Authorize]
    public class OrderController : Controller
    {
        // bring in the interface and shopping cart Model
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        // create check out action
        //name view the same name as our action, checkout
        public IActionResult Checkout()
        {
            return View();
        }

        // add model binding to view
        // trigger this action only when form/post is submitted, use http post attr
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //check if cart is empty
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }
            // if data is bound correctly, then create order
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);

                //now clear cart
                _shoppingCart.ClearCart();

                //now return checkout complete view
                return RedirectToAction("CheckoutComplete");
            }
            //preserve order
            return View(order);
        }

        //create checkout complete action
        public IActionResult CheckoutComplete()
        {
            // display message verifying order has been made
            ViewBag.CheckoutCompleteMessage = "Thank you for your order!";
            return View();
        }
    }
}
