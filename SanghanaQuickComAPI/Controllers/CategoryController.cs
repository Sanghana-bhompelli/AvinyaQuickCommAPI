using Microsoft.AspNetCore.Mvc;
using QuickComm.BusinessLayer;
using Entity.DBLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CategoryController
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly Class1 _categoryService;

        public CategoryController(Class1 categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryModels>>> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
        }
    }
}
