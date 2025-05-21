using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SanghanaQuickComAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        [HttpGet("GetAllCategories")]

        public void GetAllCategories()
        {

        }

    }
}
