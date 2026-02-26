using Microsoft.AspNetCore.Mvc;
using DotNetAssignment.Interfaces;
using DotNetAssignment.Models;

namespace DotNetAssignment.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    // GET /Product
    public IActionResult Index()
    {
        var products = _service.GetAllProducts();
        return View(products); // Views/Product/Index.cshtml
    }

    // GET /Product/Details/1
    public IActionResult Details(int id)
    {
        var product = _service.GetProductById(id);
        if (product == null) return NotFound();
        return View(product); // Views/Product/Details.cshtml
    }

    // GET /Product/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View(); // Views/Product/Create.cshtml
    }

    // POST /Product/Create
    [HttpPost]
    public IActionResult Create(Product product)
    {
        _service.AddProduct(product);
        return RedirectToAction("Index");
    }
}