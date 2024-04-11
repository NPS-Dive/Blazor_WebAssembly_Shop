using MyBlazorApp.Libraries.Products.Models;

namespace MyBlazorApp.Libraries.Cart.Models;

public class CartItemModel
	{

	/// <summary>
	/// Class constructor
	/// </summary>
	/// <param name="product"></param>
	/// <param name="productQuantity"></param>
	public CartItemModel ( ProductModel product, int productQuantity )
		{
		this.Product = product;
		this.ProductQuantity = productQuantity;
		this.ProductPrice = product.ProductPrice;
		}

	public ProductModel Product { get; }
	public float ProductPrice { get; protected set; }
	public int ProductQuantity { get; protected set; }

	
	public float TotalPrice
		{
		get
			{
			return ProductPrice * ProductQuantity;
			}
		}

	/// <summary>
	/// editing the number of each item in cart
	/// </summary>
	/// <param name="product"> cart items</param>
	/// <param name="_productQuantity"> number of each item in cart</param>
	public void UpdateQuantity ( ProductModel product, int _productQuantity )
		{
		ProductPrice = product.ProductPrice;
		ProductQuantity = _productQuantity;
		}

	}