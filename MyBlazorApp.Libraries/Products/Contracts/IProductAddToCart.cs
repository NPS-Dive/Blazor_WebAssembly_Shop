using MyBlazorApp.Libraries.Products.Models;

namespace MyBlazorApp.Libraries.Products.Contracts;

public interface IProductAddToCart
	{
	public ProductModel? Product { get; set; }
	public int? Quantity { get; set; }
	void AddToCart ();
	}