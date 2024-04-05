using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating address
        Address address1 = new Address("244 Scooby Doo Way", "SomePlace", "CA", "USA");
        Address address2 = new Address("110 Tinroof", "Ebenezer", "Guadaljara", "Mexico");

        // Creating customers
        Customer customer1 = new Customer("Ty Moulton", address1);
        Customer customer2 = new Customer("Alex Pisarski", address2);

        // Creating products
        Product product1 = new Product("Snowboard", "PRD2376", 10.99, 2);
        Product product2 = new Product("Boa Boots", "PRD8543", 20.50, 1);
        Product product3 = new Product("Bindings", "PRD6190", 15.75, 3);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Displaying order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}