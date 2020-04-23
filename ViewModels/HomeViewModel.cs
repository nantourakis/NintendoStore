using NintendoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.ViewModels
{
    public class HomeViewModel
    {
        // IEnumerabke list of type Game
        // now this ready to be used within a view
        public IEnumerable<Game> GameOnSale { get; set; }
    }
}
