using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        // each category will contain specefic games, so we create a property of a list of games
        public List<Game> Games { get; set; }
    }
}
