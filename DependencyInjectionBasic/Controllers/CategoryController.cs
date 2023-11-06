using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionBasic.Controllers
{
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private ICategoryRepository category { get; set; }
        public CategoryController(ICategoryRepository category)
        {
            this.category = category;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Category> categories = category.GetCategories();
            return Ok(categories);
        }
    }
}
