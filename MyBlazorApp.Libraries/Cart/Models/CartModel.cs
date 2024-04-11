namespace MyBlazorApp.Libraries.Cart.Models;

public class CartModel
{
	/// <summary>
	/// Class  Constructor
	/// </summary>
	/// <param name="items"></param>
	public CartModel()
	{
		Items = new List<CartItemModel>();
	}

	public IList<CartItemModel> Items { get; }
}