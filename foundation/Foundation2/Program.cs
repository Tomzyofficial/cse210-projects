using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Create customers addresses
    Address address1 = new Address("156 Main St", "New York", "NY", "USA");
    Address address2 = new Address("401 Elm St", "Toronto", "Ontario", "Canada");
    // Create customers
    Customer customer1 = new Customer("Chukwuebuka Ibeh", address1);
    Customer customer2 = new Customer("Francis Ibeh", address2);
    // Create products
    Product product1 = new Product("Laptop", "HP Elitebook", 1100.00, 1);
    Product product2 = new Product("Headset", "Apple", 30.00, 2);
    Product product3 = new Product("Laptop Holder", "C100", 15.00, 1);
    // Create first order
    Order order1 = new Order(customer1);
    order1.AddProduct(product1);
    order1.AddProduct(product2);
    // Create second order
    Order order2 = new Order(customer2);
    order2.AddProduct(product2);
    order2.AddProduct(product3);
    // Display results for order 1
    Console.WriteLine(order1.GetPackingLabel());
    Console.WriteLine(order1.GetShippingLabel());
    Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");
    // Display results for order 2
    Console.WriteLine(order2.GetPackingLabel());
    Console.WriteLine(order2.GetShippingLabel());
    Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
  }
}

// Order class
class Order
{
  private List<Product> products;
  private Customer customer;
  public Order(Customer customer)
  {
    this.customer = customer;
    this.products = new List<Product>();
  }
  // Add product method
  public void AddProduct(Product product)
  {
    products.Add(product);
  }
  // Get the total cost
  public double GetTotalCost()
  {
    double totalCost = 0;
    foreach (var product in products)
    {
      totalCost += product.GetTotalCost();
    }
    // Add shipping cost
    totalCost += customer.IsInUSA() ? 5.00 : 35.00;
    return totalCost;
  }
  // Packing label
  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";
    foreach (var product in products)
    {
      label += product.GetPackingLabel() + "\n";
    }
    return label;
  }

  public string GetShippingLabel()
  {
    return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
  }
}

// product class
class Product
{
  private string _name;
  private string _productId;
  private double _price;
  private int _quantity;

  public Product(string name, string productId, double price, int quantity)
  {
    this._name = name;
    this._productId = productId;
    this._price = price;
    this._quantity = quantity;
  }

  public double GetTotalCost()
  {
    return _price * _quantity;
  }

  public string GetPackingLabel()
  {
    return $"Product: {_name}, ID: {_productId}";
  }
}

// Customer class
class Customer
{
  private string _name;
  private Address address;

  public Customer(string name, Address address)
  {
    this._name = name;
    this.address = address;
  }

  public bool IsInUSA()
  {
    return address.IsInUSA();
  }

  public string GetName()
  {
    return _name;
  }

  public string GetAddress()
  {
    return address.GetFullAddress();
  }
}

// Address class
class Address
{
  private string _street;
  private string _city;
  private string _state;
  private string _country;

  public Address(string street, string city, string state, string country)
  {
    this._street = street;
    this._city = city;
    this._state = state;
    this._country = country;
  }
  public bool IsInUSA()
  {
    return _country.ToLower() == "usa";
  }

  public string GetFullAddress()
  {
    return $"{_street}\n{_city}, {_state}\n{_country}";
  }
}