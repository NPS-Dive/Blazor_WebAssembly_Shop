using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorApp.Libraries.Cart.Contracts;
using MyBlazorApp.Libraries.Cart.Services;
using MyBlazorApp.Libraries.Products.Contracts;
using MyBlazorApp.Libraries.Products.Services;
using MyBlazorApp.Libraries.Storage.Contracts;
using MyBlazorApp.Libraries.Storage.Services;

namespace BlazorProject01
	{
	public class Program
		{
		public static async Task Main ( string[] args )
			{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

			builder.Services.AddSingleton<IStorageService, StorageService>();
			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddTransient<ICartService,CartService>();

			await builder.Build().RunAsync();
			}
		}
	}
