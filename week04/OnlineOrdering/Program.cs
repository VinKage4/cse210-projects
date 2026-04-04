using System;

class Program
{
    static void Main(string[] args)
    {
        // First order
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Vinicius Sousa", address1);

        Product product1 = new Product("Keyboard", "A101", 25.50, 2);
        Product product2 = new Product("Mouse", "B205", 15.75, 1);
        Product product3 = new Product("Monitor", "C309", 180.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Second order
        Address address2 = new Address("456 King Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Lucas Pereira", address2);

        Product product4 = new Product("Headset", "D410", 45.99, 1);
        Product product5 = new Product("Webcam", "E511", 70.00, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display first order
        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine();

        // Display second order
        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}