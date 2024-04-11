using MyBlazorApp.Libraries.Cart.Models;
using MyBlazorApp.Libraries.Products.Models;

namespace MyBlazorApp.Libraries.Cart.Contracts;

public interface ICartService
	{
	CartModel Get ();
	void InsertProduct ( ProductModel product, int quantity );
	void DeleteProduct ( CartItemModel cartItem );
	int Count ();
	bool HasProduct ( string sku);
	}