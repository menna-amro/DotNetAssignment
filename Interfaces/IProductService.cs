using DotNetAssignment.Models;

namespace DotNetAssignment.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product? GetProductById(int id);
    void AddProduct(Product product);
}