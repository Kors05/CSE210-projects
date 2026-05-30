using System;

class Program
{
    static void Main(string[] args)
    {
        // CUSTOMER 1 (USA)
        Address addr1 = new Address("12 Elm St", "Dallas", "TX", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", 101, 800, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total: $" + order1.GetTotalPrice());
        Console.WriteLine("----------------------");

        // CUSTOMER 2 (Non-USA)
        Address addr2 = new Address("45 Rue St", "Paris", "Île-de-France", "France");
        Customer cust2 = new Customer("Marie Dubois", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", 201, 600, 1));
        order2.AddProduct(new Product("Case", 202, 20, 3));

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total: $" + order2.GetTotalPrice());
    }
}