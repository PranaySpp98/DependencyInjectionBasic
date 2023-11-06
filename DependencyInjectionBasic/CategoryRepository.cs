using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionBasic
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            Category category = new Category() { CategoryId = 1, CategoryName = "Food" };
            categories.Add(category);
            category = new Category() { CategoryId = 2, CategoryName = "SW" };
            categories.Add(category);

            return categories;
        }
    }
}
