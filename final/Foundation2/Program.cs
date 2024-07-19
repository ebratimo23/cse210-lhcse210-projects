class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak Ave", "Sometown", "NY", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to order 1
        Product product1 = new Product("Laptop", 1, 1200.50m, 1);
        Product product2 = new Product("Mouse", 2, 25.75m, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Add products to order 2
        Product product3 = new Product("Keyboard", 3, 50.00m, 1);
        order2.AddProduct(product3);

        // Display order 1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        // Display order 2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
