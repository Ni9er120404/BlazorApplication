using BlazorApplication.Shared;
using System.Net.Http.Json;

namespace BlazorApplication.Client.Services.ProductService
{
	public class ProductService : IProductService
	{

		private readonly HttpClient _httpClient;

		public ProductService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public List<Product>? Products { get; set; } = new();

		public event Action? OnChange;

		public async Task<Product> GetProduct(int id)
		{
			Product? product = await _httpClient.GetFromJsonAsync<Product>($"api/Product/{id}");

			return product is null ? throw new Exception($"Product with id {id} not found") : product;
		}

		public async Task LoadProducts(string? categoryUrl = null)
		{
			if (categoryUrl is null)
			{
				Products = await _httpClient.GetFromJsonAsync<List<Product>>("api/Product");
			}
			else
			{
				Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
			}

			OnChange!.Invoke();
		}
	}
}