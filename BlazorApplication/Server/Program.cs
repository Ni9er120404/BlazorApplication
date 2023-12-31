using BlazorApplication.Server.Data;
using BlazorApplication.Server.Services.CategoryService;
using BlazorApplication.Server.Services.ProductService;
using Microsoft.EntityFrameworkCore;

namespace BlazorApplication.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            _ = builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
            _ = builder.Services.AddControllersWithViews();
            _ = builder.Services.AddRazorPages();

            _ = builder.Services.AddScoped<IProductService, ProductService>();
            _ = builder.Services.AddScoped<ICategoryService, CategoryService>();

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