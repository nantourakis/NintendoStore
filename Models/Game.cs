using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class Game
    {
        // Define Properties 

        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        
        public string ShortDescription { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }
        public bool IsonSale { get; set; }

        public bool IsInStock { get; set; }

        public string GameSystem { get; set; }

        //Each Candy will be apart of a category class, bring our Category class into Game class

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Models contain all the date we need to work within the application
        // BUT in order to process the date, we will need repositories and create interfaces for each repository
        //since we are using Dependency Injection. inject our repository services into our application

    }
}
