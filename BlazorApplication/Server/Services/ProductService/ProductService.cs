using BlazorApplication.Server.Data;
using BlazorApplication.Server.Services.CategoryService;
using BlazorApplication.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApplication.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly Context _context;

        public ProductService(ICategoryService categoryService, Context context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> products = await _context.Products
                .Include(product => product.Variants)
                .ToListAsync();

            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            Product? products = await _context.Products
                .Include(product => product.Variants)
                .ThenInclude(productVariant => productVariant.Edition)
                .FirstOrDefaultAsync(product => product.Id == id);

            return products is null ? throw new Exception("Product not found") : products;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);

            List<Product>? products = await _context.Products
                .Include(product => product.Variants)
                .Where(product => product.CategoryId == category.Id)
                .ToListAsync();

            return products is null ? throw new Exception("Product not found") : products;
        }
    }
}