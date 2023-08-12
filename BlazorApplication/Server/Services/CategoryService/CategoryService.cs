using BlazorApplication.Server.Data;
using BlazorApplication.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApplication.Server.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		private readonly Context _context;

		public CategoryService(Context context)
		{
			_context = context;
		}

		public async Task<List<Category>> GetAllCategories()
		{
			List<Category> categories = await _context.Categories.ToListAsync();

			return categories;
		}

		public async Task<Category> GetCategoryByUrl(string categoryUrl)
		{
			Category? category = await _context.Categories.FirstOrDefaultAsync(category => category.Url.ToLower() == categoryUrl.ToLower());

			return category is null ? throw new Exception("Category not found") : category;
		}
	}
}