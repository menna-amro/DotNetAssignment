using DotNetAssignment.Interfaces;
using DotNetAssignment.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotNetAssignment.Services;

public class ProductService : IProductService
{
    private List<Product> products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 15000 },
        new Product { Id = 2, Name = "Mouse", Price = 200 },
        new Product { Id = 3, Name = "Keyboard", Price = 500 }
    };

    public IEnumerable<Product> GetAllProducts() => products;

    public Product? GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

    public void AddProduct(Product product)
    {
        // Assign a new Id = max existing Id + 1
        int newId = products.Any() ? products.Max(p => p.Id) + 1 : 1;
        product.Id = newId;
        products.Add(product);
    }
}