using MyBlazorApp.Libraries.Products.Models;

namespace MyBlazorApp.Libraries.Products.Contracts;

public interface IProductService
{
    ProductModel? GetProduct(string sku);
    ProductModel? GetProductBySlug(string slug);
    IList<ProductModel> GetAll();
}