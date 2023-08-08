using BlazorApplication.Shared;

namespace BlazorApplication.Client.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		public List<Category> Categories { get; set; } = new();

		public void LoadCategories()
		{
			Categories = new List<Category>()
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
		}
	}
}