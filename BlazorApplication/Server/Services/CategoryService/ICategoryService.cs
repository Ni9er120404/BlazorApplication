using BlazorApplication.Shared;

namespace BlazorApplication.Server.Services.CategoryService
{
	public interface ICategoryService
	{
		public Task<List<Category>> GetAllCategories();

		public Task<Category> GetCategoryByUrl(string categoryUrl);
	}
}