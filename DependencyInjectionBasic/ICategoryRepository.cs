using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionBasic
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
