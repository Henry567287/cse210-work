using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B1", 10.0, 2));
        order1.AddProduct(new Product("Pen", "P1", 2.0, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        // Order 2 (International customer)
        Address address2 = new Address("45 Rue", "Paris", "", "France");
        Customer customer2 = new Customer("Marie Claire", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Shoes", "S1", 50.0, 1));
        order2.AddProduct(new Product("Bag", "B2", 30.0, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}