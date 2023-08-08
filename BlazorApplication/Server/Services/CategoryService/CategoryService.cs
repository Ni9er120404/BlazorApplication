using BlazorApplication.Shared;

namespace BlazorApplication.Server.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		public List<Category> Categories { get; set; } = new()
		{
			new Category()
				{
					Id=1,
					Name = "Fantasy",
					Url="fantasy",
					Icon="fantasy"
				},
				new Category()
				{
					Id=2,
					Name = "Science Fiction",
					Url="science-fiction",
					Icon="science-fiction"
				},
				new Category()
				{
					Id=3,
					Name = "Horror",
					Url="horror",
					Icon="horror"
				}
		};

		public async Task<List<Category>> GetAllCategories()
		{
			return Categories;
		}

		public async Task<Category> GetCategoryByUrl(string categoryUrl)
		{
			Category? category = Categories.FirstOrDefault(category => category.Url.ToLower() == categoryUrl.ToLower());

			return category;
		}
	}
}