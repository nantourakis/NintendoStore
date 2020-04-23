using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NintendoStore.Models;
using NintendoStore.ViewModels;

namespace NintendoStore.Controllers
{
    public class GameController : Controller
    {
        // in order to use the data from our repos, we need to access them
        //bring them in as read only field for our interfaces

        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;

        //now instiate these fields, we do that by injecting these services into a constructor
        public GameController(IGameRepository gameRepository, ICategoryRepository categoryRepository)
        {
            // underscore repository will be equal to the injected repository
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;

            //we now have access to our controller
        }

        //no we create our action method for handling requests into a view that returns a list og all games
        // return view for action
        // ViewBag.CurrentCategory = "Best Sellers"; // Better to do with ViewModels
        // return View(_gameRepository.GetAllGames);

        //init the View Model
       /* Old Code var gameListViewModel = new GameListViewModel();
        gameListViewModel.Games = _gameRepository.GetAllGames;
            gameListViewModel.CurrentCategory = "Best Sellers";
            return View(gameListViewModel);*/
        public ViewResult List(string category)
        {
            //Filter through each category we want to show with our route
            IEnumerable<Game> games;
            string currentCategory;

            // if category is empty
            if (string.IsNullOrEmpty(category))
            {
                games = _gameRepository.GetAllGames.OrderBy(c => c.GameId);

                currentCategory = "All Games";
            }
            //if category is supplied
            else
            {
                games = _gameRepository.GetAllGames.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new GameListViewModel
            {
                Games = games,
                CurrentCategory = currentCategory
            });
            
        }

        // Add Action For Routing(Details action), and an ID paramater
        // Linked to Details View
        public IActionResult Details(int id)
        {
            var game = _gameRepository.GetGameById(id);
            // check to see if game is == to null, if that's true return a 404, if not then return the game id
                return game == null ? NotFound() : (IActionResult)View(game);

            /* same thing
             if (game == null)
                return NotFound();

            return View(game);*/
        }

    }
}