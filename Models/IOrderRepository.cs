using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public interface IOrderRepository
    {
        // create order

        void CreateOrder(Order order);
    }
}
