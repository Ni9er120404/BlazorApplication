using BlazorApplication.Shared;
using System.Net.Http.Json;

namespace BlazorApplication.Client.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		private readonly HttpClient _httpClient;

		public List<Category>? Categories { get; set; } = new();

		public CategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task LoadCategories()
		{
			Categories = await _httpClient.GetFromJsonAsync<List<Category>>("api/category")!;
		}
	}
}