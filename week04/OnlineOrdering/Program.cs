using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // System welcome message
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            Console.WriteLine("         NOVAVEC TECNOLOGY - ORDER MANAGEMENT SYSTEM  ");
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            Console.WriteLine();

            // ORDER #1: U.S. Customerr

            Address address1 = new Address("749 Evergreen St", "Springfield", "OR", "USA");
            Customer customer1 = new Customer("Will Smith", address1);
            Order order1 = new Order(customer1);

            Product product1 = new Product("Pro Laptop 16-inch", "LAP-9001", 1899.99m, 1);
            Product product2 = new Product("Wireless Mechanical Keyboard", "KB-750W", 149.50m, 1);
            Product product3 = new Product("Ergonomic Wireless Mouse", "MS-300W", 79.99m, 1);

            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            Console.WriteLine("================================================================");
            Console.WriteLine("ORDER N°1");
            Console.WriteLine("================================================================");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
            Console.WriteLine();


            // ORDER #2: Venezuelan Customer
            Address address2 = new Address("Páez St", "La Victoria", "Aragua", "Venezuela");
            Customer customer2 = new Customer("María González", address2);
            Order order2 = new Order(customer2);

            Product product4 = new Product("Noise Cancelling Headphones", "AUD-1000X", 349.99m, 1);
            Product product5 = new Product("4K Ultra-Wide Monitor 34\"", "MON-344K", 699.00m, 1);
            Product product6 = new Product("NOBIS Portable Charger, 20,000 mAh Power Bank", "BKP-0801", 32.99m, 4);

            order2.AddProduct(product4);
            order2.AddProduct(product5);
            order2.AddProduct(product6);


            Console.WriteLine("================================================================");
            Console.WriteLine("ORDER N°2");
            Console.WriteLine("================================================================");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
            Console.WriteLine();
        }
    }
}