using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NintendoStore.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        // implements the ICategory Interface

        //create a new List of type Category, and add the new categories here

        // bring in db context and then inject into the constructor
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;

    }
}
