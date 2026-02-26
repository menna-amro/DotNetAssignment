# DotNetAssignment

## Project Overview
A .NET MVC application with two models (Customer and Product) demonstrating CRUD operations and proper MVC structure.

## Models
- **Customer** → Id, Name, Email
- **Product** → Id, Name, Price (validated to prevent negative values)

## Interfaces
- **ICustomerService**
  - `GetAllCustomers()`
  - `GetCustomerById()`
  - `AddCustomer()`
- **IProductService**
  - `GetAllProducts()`
  - `GetProductById()`
  - `AddProduct()`

## Services
- In-memory storage using `List<T>`
- Auto-increment IDs for new items

## Controllers
- **CustomerController** → `Index`, `Details`, `Create`
- **ProductController** → `Index`, `Details`, `Create`

## Views
- `Index`, `Details`, `Create` for both Customers and Products
- Forms have validation (e.g., Product price ≥ 0)
- Proper navigation links included
