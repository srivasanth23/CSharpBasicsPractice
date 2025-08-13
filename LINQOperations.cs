using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasicsPractice
{
    // Product class with properties
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }
    }

    public class LinqCSharp
    {
        public void Execute()
        {
            // Creating 10 products
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Id = 1, Price = 65000, ManufactureDate = new DateTime(2024, 05, 10) },
                new Product { Name = "Mobile", Id = 2, Price = 25000, ManufactureDate = new DateTime(2023, 12, 20) },
                new Product { Name = "Tablet", Id = 3, Price = 30000, ManufactureDate = new DateTime(2024, 01, 15) },
                new Product { Name = "Monitor", Id = 4, Price = 15000, ManufactureDate = new DateTime(2022, 11, 05) },
                new Product { Name = "Keyboard", Id = 5, Price = 1500, ManufactureDate = new DateTime(2023, 08, 12) },
                new Product { Name = "Mouse", Id = 6, Price = 800, ManufactureDate = new DateTime(2023, 09, 18) },
                new Product { Name = "Printer", Id = 7, Price = 12000, ManufactureDate = new DateTime(2022, 07, 25) },
                new Product { Name = "Camera", Id = 8, Price = 55000, ManufactureDate = new DateTime(2023, 04, 14) },
                new Product { Name = "Speaker", Id = 9, Price = 3500, ManufactureDate = new DateTime(2023, 10, 10) },
                new Product { Name = "Smartwatch", Id = 10, Price = 18000, ManufactureDate = new DateTime(2024, 02, 05) }
            };

            // LINQ Examples with comments

            // 1. OrderBy with ThenBy
            var orderedProducts = products.OrderBy(p => p.Price).ThenBy(p => p.Name);
            Console.WriteLine("Ordered by Price, then Name:");
            foreach (var p in orderedProducts) Console.WriteLine($"{p.Name} - {p.Price}");

            // 2. GroupBy
            var groupedByYear = products.GroupBy(p => p.ManufactureDate.Year);
            Console.WriteLine("\nGrouped by Manufacture Year:");
            foreach (var group in groupedByYear)
            {
                Console.WriteLine($"Year: {group.Key}");
                foreach (var p in group) Console.WriteLine($"  {p.Name}");
            }

            // 3. GroupBy with into
            var expensiveGroups = products
                .GroupBy(p => p.Price > 20000 ? "Expensive" : "Affordable")
                .Select(g => new { Category = g.Key, Items = g.ToList() });
            Console.WriteLine("\nGrouped into Expensive/Affordable:");
            foreach (var g in expensiveGroups)
            {
                Console.WriteLine($"{g.Category}:");
                foreach (var p in g.Items) Console.WriteLine($"  {p.Name} - {p.Price}");
            }

            // 4. Select
            var productNames = products.Select(p => p.Name);
            Console.WriteLine("\nProduct Names:");
            foreach (var name in productNames) Console.WriteLine(name);

            // 5. SelectMany (flatten list of chars in names)
            var allChars = products.SelectMany(p => p.Name.ToCharArray());
            Console.WriteLine("\nAll Characters in Names:");
            foreach (var ch in allChars) Console.Write($"{ch} ");
            Console.WriteLine();

            // 6. Take
            var first3 = products.Take(3);
            Console.WriteLine("\nFirst 3 Products:");
            foreach (var p in first3) Console.WriteLine(p.Name);

            // 7. TakeWhile (take while price > 1000)
            var takeWhileExpensive = products.TakeWhile(p => p.Price > 1000);
            Console.WriteLine("\nTakeWhile Price > 1000:");
            foreach (var p in takeWhileExpensive) Console.WriteLine($"{p.Name} - {p.Price}");

            // 8. First
            var firstProduct = products.First();
            Console.WriteLine($"\nFirst Product: {firstProduct.Name}");

            // 9. FirstOrDefault (with condition)
            var firstCheap = products.FirstOrDefault(p => p.Price < 1000);
            Console.WriteLine($"First Product Price < 1000: {(firstCheap != null ? firstCheap.Name : "None")}");

            // 10. Single (exact match)
            try
            {
                var singleProduct = products.Single(p => p.Id == 5);
                Console.WriteLine($"\nSingle Product with ID 5: {singleProduct.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Single(): {ex.Message}");
            }

            // 11. SingleOrDefault
            var singleOrDefaultProduct = products.SingleOrDefault(p => p.Id == 50);
            Console.WriteLine($"SingleOrDefault Product with ID 50: {(singleOrDefaultProduct != null ? singleOrDefaultProduct.Name : "None")}");
        }
    }
}
