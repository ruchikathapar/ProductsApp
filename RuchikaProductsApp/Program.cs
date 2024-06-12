using System;

namespace RuchikaProductApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Product product = new Product(1, "Laptop", 1200.50m, 50);

                DisplayProductDetails(product);

                // Increasing stock
                product.IncreaseStock(25);
                Console.WriteLine("\nIncreased stock by 25.");
                DisplayProductDetails(product);

                // Decreasing stock
                product.DecreaseStock(10);
                Console.WriteLine("\nDecreased stock by 10.");
                DisplayProductDetails(product);

                // Decrease stock by higher value than available
                Console.WriteLine("\nAttempting to decrease stock by 70...");
                product.DecreaseStock(70);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void DisplayProductDetails(Product product)
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine($"ID: {product.ProductID}");
            Console.WriteLine($"Name: {product.ProductName}");
            Console.WriteLine($"Price: {product.Price:C}");
            Console.WriteLine($"Stock: {product.Stock}");
        }
    }
}