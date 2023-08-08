using BlazorApplication.Client.Services.CategoryService;
using BlazorApplication.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApplication.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			_ = builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			_ = builder.Services.AddScoped<IProductService, ProductService>();
			_ = builder.Services.AddScoped<ICategoryService, CategoryService>();

			await builder.Build().RunAsync();
		}
	}
}