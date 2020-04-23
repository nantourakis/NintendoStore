using NintendoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.ViewModels
{
    public class GameListViewModel
    {
        //display each of the candy 
        public IEnumerable<Game> Games { get; set; }
        public string CurrentCategory { get; set; }
    }
}
