using MyBlazorApp.Libraries.Products.Contracts;
using MyBlazorApp.Libraries.Products.Models;
using MyBlazorApp.Libraries.Storage.Contracts;

namespace MyBlazorApp.Libraries.Products.Services;

public class ProductService : IProductService
	{
	private readonly IStorageService _storageService;

	public ProductService ( IStorageService storageService )
		{
		this._storageService = storageService;
		}

	public ProductModel? GetProduct ( string sku )
	{
		return _storageService.Products.FirstOrDefault(pr => pr.SKU == sku);
	}

	public ProductModel? GetProductBySlug ( string slug )
	{
		return _storageService.Products.FirstOrDefault(pr => pr.Slug == slug);
	}

	public IList<ProductModel> GetAll ()
	{
		return _storageService.Products.ToList();
	}
	}