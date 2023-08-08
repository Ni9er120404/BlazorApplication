using BlazorApplication.Shared;

namespace BlazorApplication.Client.Services.ProductService
{
	public interface IProductService
	{
		public event Action? OnChange;

		public List<Product>? Products { get; set; }

		public Task LoadProducts(string? categoryUrl = null);

		public Task<Product> GetProduct(int id);
	}
}