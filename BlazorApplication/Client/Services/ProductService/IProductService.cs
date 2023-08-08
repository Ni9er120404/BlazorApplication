using BlazorApplication.Shared;

namespace BlazorApplication.Client.Services.ProductService
{
	public interface IProductService
	{
		public List<Product> Products { get; set; }

		public void LoadProducts();
	}
}