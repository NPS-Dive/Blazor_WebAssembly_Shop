using MyBlazorApp.Libraries.Cart.Contracts;
using MyBlazorApp.Libraries.Cart.Models;
using MyBlazorApp.Libraries.Products.Models;
using MyBlazorApp.Libraries.Storage.Contracts;

namespace MyBlazorApp.Libraries.Cart.Services;

public class CartService : ICartService
	{
	private readonly IStorageService _storageService;

	public CartService ( IStorageService storageService )
		{
		_storageService = storageService;
		}

	public CartModel Get ()
		{
		return _storageService.Cart;
		}

	public void InsertProduct ( ProductModel product, int quantity )
		{
		var items = Get().Items;
		if (HasProduct(product.SKU))
			{
			var item = items.First(item => item.Product.SKU == product.SKU);
			item.UpdateQuantity(product, quantity);
			}
		else
			{
			items.Add(new CartItemModel(product, quantity));
			}
		}

	public void DeleteProduct ( CartItemModel cartItem )
		{
		var items = Get().Items;
		if (HasProduct(cartItem.Product.SKU))
			{
			items.Remove(items.First(item => item.Product.SKU == cartItem.Product.SKU));
			}
		}

	public int Count ()
		{
		return Get().Items.Count;
		}

	public bool HasProduct ( string sku )
	{
		var Cart = Get();
		return Cart.Items.Any(i=>i.Product.SKU== sku);
	}
	}