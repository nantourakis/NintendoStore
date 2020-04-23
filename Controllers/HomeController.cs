using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NintendoStore.Models;
using NintendoStore.ViewModels;

namespace NintendoStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly IGameRepository _gameRepository;

        //inject repository into constructor
        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
            //bring in view Model to our action
            var homeViewModel = new HomeViewModel
            {
                GameOnSale = _gameRepository.GetGamesOnSale
            };
            return View(homeViewModel);
        }
    }
}