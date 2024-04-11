namespace MyBlazorApp.Libraries.Products.Models;

public class ProductModel
	{

	/// <summary>
	/// Class Constructor
	/// </summary>
	/// <param name="sku"></param>
	/// <param name="productName"></param>
	/// <param name="productDescription"></param>
	/// <param name="productPrice"></param>
	/// <param name="productImgAddress"></param>
	public ProductModel ( string sku, string productName, string productDescription, float productPrice, string productImgAddress )
		{
		this.SKU = sku;
		this.ProductName = productName;
		this.ProductDescription = productDescription;
		this.ProductPrice = productPrice;
		this.ProductImgAddress = productImgAddress;
		}

	public String SKU { get; set; }
	public String ProductName { get; set; }
	public String ProductDescription { get; set; }
	public float ProductPrice { get; set; }
	public String ProductImgAddress { get; set; }

	public String Slug
		{
		get
			{
			return SKU.ToLower();
			}
		}

	public string ProductUrl
		{
		get
			{
			return String.Format("/Product/{0}", Slug);
			}
		}


	}