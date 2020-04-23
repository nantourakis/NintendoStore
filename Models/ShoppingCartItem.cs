using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class ShoppingCartItem
    {
        //add properties to Model
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Game Game { get; set; }
        public int Amount { get; set; }
    }
}
