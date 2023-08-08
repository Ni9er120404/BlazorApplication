using BlazorApplication.Server.Services.CategoryService;
using BlazorApplication.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = await _categoryService.GetAllCategories();

            return Ok(categories);
        }
    }
}