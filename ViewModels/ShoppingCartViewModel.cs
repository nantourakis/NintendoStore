using NintendoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.ViewModels
{
    public class ShoppingCartViewModel
    {

        public ShoppingCart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }

        public Game Game { get; set; }
    }
}
