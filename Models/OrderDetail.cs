using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public class OrderDetail
    {
        
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int Amount { get; set; }

        public decimal Price { get; set; }

        // create the relationship with the Order Object
        public Order Order { get; set; }
    }
}
