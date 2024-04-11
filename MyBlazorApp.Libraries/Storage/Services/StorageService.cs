using MyBlazorApp.Libraries.Cart.Models;
using MyBlazorApp.Libraries.Products.Models;
using MyBlazorApp.Libraries.Storage.Contracts;

namespace MyBlazorApp.Libraries.Storage.Services;

public class StorageService : IStorageService
	{
		public IList<ProductModel> Products { get; private set; }
		public CartModel Cart { get; private set; }

		public StorageService()
		{
			Products = new List<ProductModel>();
			Cart = new CartModel();

			//list of sample products

			AddProduct(new ProductModel("migmig-Big-2815-Bingo", "Bubble Gum", "1 Carton of Cinnamon Bubble Gum", 165, "01.jpg"));
			AddProduct(new ProductModel("bigudi-Nayab-65-dall", "Tennis Rackets", "Carbon Tennis Racket", 170, "02.jpg"));
			AddProduct(new ProductModel("ingo-mingo-75-dingo", "Jeans", "Classic Men's Jeans", 175, "03.jpg"));
			AddProduct(new ProductModel("shin-mim-sin-98", "Yellow T-Shirt", "Yellow Blazor T-shirt", 180, "04.jpg"));
			AddProduct(new ProductModel("dbel-akona-miuu", "Banana", "1 carton of Banana", 185, "05.jpg"));
			AddProduct(new ProductModel("fun-man-tan-85", "Ice Cream", "A pack of 20 IceCreams", 175, "06.jpg"));


		}

		private void AddProduct(ProductModel newProduct)
		{
			if (!Products.Any(pr => pr.SKU == newProduct.SKU))
			{
				Products.Add(newProduct);
			}
		}
	}