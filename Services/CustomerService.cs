using DotNetAssignment.Interfaces;
using DotNetAssignment.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotNetAssignment.Services;

public class CustomerService : ICustomerService
{
    private List<Customer> customers = new()
    {
        new Customer { Id = 1, Name = "Menna", Email = "menna@gmail.com" },
        new Customer { Id = 2, Name = "Yara", Email = "yara@gmail.com" }
    };

    public IEnumerable<Customer> GetAllCustomers() => customers;

    public Customer? GetCustomerById(int id) => customers.FirstOrDefault(c => c.Id == id);

    public void AddCustomer(Customer customer)
    {
        // Assign a new Id = max existing Id + 1
        int newId = customers.Any() ? customers.Max(c => c.Id) + 1 : 1;
        customer.Id = newId;
        customers.Add(customer);
    }
}