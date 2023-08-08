namespace BlazorApplication.Server
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

			_ = builder.Services.AddControllersWithViews();
			_ = builder.Services.AddRazorPages();

			using WebApplication app = builder.Build();

			if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				_ = app.UseExceptionHandler("/Error");
				_ = app.UseHsts();
			}

			_ = app.UseHttpsRedirection();

			_ = app.UseBlazorFrameworkFiles();
			_ = app.UseStaticFiles();

			_ = app.UseRouting();

			_ = app.MapRazorPages();
			_ = app.MapControllers();
			_ = app.MapFallbackToFile("index.html");

			app.Run();
		}
	}
}