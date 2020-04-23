using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    public interface ICategoryRepository
    {

        // what METHODS do we need in our Category interface? - list here

        IEnumerable<Category> GetAllCategories { get;  }


        // interface is created, now we need to create our repositories to implement this Methods and Props
    }
}
