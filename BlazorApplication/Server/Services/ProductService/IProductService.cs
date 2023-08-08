using BlazorApplication.Shared;

namespace BlazorApplication.Server.Services.ProductService
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProducts();

        public Task<List<Product>> GetProductsByCategory(string categoryUrl);

        public Task<Product> GetProductById(int id);
    }
}