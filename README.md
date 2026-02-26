Project Overview:
A .NET MVC application with two models (Customer and Product) demonstrating CRUD operations and proper MVC structure.

What’s implemented:

1)Models:

Customer → Id, Name, Email

Product → Id, Name, Price (validated to prevent negative values)

2)Interfaces:

-ICustomerService → GetAllCustomers(), GetCustomerById(), AddCustomer()

-IProductService → GetAllProducts(), GetProductById(), AddProduct()

3)Services:

-In-memory storage using List<T>

-Auto-increment IDs for new items

4)Controllers:

-CustomerController → Index, Details, Create 

-ProductController → Index, Details, Create 

5)Views:

-Index, Details, Create for both Customers and Products

-Forms have validation (ex: Product price ≥ 0)

-Proper navigation links included
