using Microsoft.AspNetCore.Mvc;
using DotNetAssignment.Interfaces;
using DotNetAssignment.Models;

namespace DotNetAssignment.Controllers;

public class CustomerController : Controller
{
    private readonly ICustomerService _service;

    public CustomerController(ICustomerService service)
    {
        _service = service;
    }

    // GET /Customer
    public IActionResult Index()
    {
        var customers = _service.GetAllCustomers();
        return View(customers); // Views/Customer/Index.cshtml
    }

    // GET /Customer/Details/1
    public IActionResult Details(int id)
    {
        var customer = _service.GetCustomerById(id);
        if (customer == null) return NotFound();
        return View(customer); // Views/Customer/Details.cshtml
    }

    // GET /Customer/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View(); // Views/Customer/Create.cshtml
    }

    // POST /Customer/Create
    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        _service.AddCustomer(customer);
        return RedirectToAction("Index");
    }
}