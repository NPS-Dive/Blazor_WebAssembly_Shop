using MyBlazorApp.Libraries.Cart.Models;
using MyBlazorApp.Libraries.Products.Models;

namespace MyBlazorApp.Libraries.Storage.Contracts;

public interface IStorageService
	{
	IList<ProductModel> Products { get; }
	CartModel Cart { get; }
	}