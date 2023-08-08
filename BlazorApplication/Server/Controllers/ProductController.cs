using BlazorApplication.Server.Services.ProductService;
using BlazorApplication.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApplication.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<ActionResult<List<Product>>> GetAllProducts()
		{
			List<Product> products = await _productService.GetAllProducts();

			return Ok(products);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProductById(int id)
		{
			Product product = await _productService.GetProductById(id);

			return Ok(product);
		}

		[HttpGet("Category/{categoryUrl}")]
		public async Task<ActionResult<List<Product>>> GetProductByCategory(string categoryUrl)
		{
			List<Product> products = await _productService.GetProductsByCategory(categoryUrl);

			return Ok(products);
		}
	}
}