using BlazorApplication.Shared;

namespace BlazorApplication.Client.Services.CategoryService
{
	public interface ICategoryService
	{
		public List<Category> Categories { get; set; }

		public void LoadCategories();
	}
}