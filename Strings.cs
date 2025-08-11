using System;
using System.Text;

namespace CSharpBasicsPractice
{
    public class Strings
    {
        public void Run()
        {
            // Creation
            string str1 = "Hello";
            string str2 = new string('*', 5);
            Console.WriteLine($"str1: {str1}, str2: {str2}");

            // Properties
            Console.WriteLine($"Length: {str1.Length}");

            // Concatenation
            string concat = $"{str1} World";
            Console.WriteLine(concat);

            // Access
            Console.WriteLine($"First char: {str1[0]}, Last char: {str1[^1]}");

            // Searching
            Console.WriteLine(concat.Contains("World"));

            // Case conversion
            Console.WriteLine(concat.ToUpper());

            // Trim
            Console.WriteLine("   Hi   ".Trim());

            // Substring & Replace
            Console.WriteLine(concat.Substring(0, 5));
            Console.WriteLine(concat.Replace("World", "C#"));

            // Split & Join
            string fruits = "Apple,Banana,Mango";
            var arr = fruits.Split(',');
            Console.WriteLine(string.Join(" | ", arr));

            // Comparison
            Console.WriteLine("Hello".Equals("hello", StringComparison.OrdinalIgnoreCase));

            // Null/Empty
            Console.WriteLine(string.IsNullOrEmpty(""));
            Console.WriteLine(string.IsNullOrWhiteSpace(" "));

            // Verbatim & Interpolation
            string path = @"C:\Users\Vasanth\Docs";
            Console.WriteLine(path);
            Console.WriteLine($"Hello, {str1}");

            // StringBuilder
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World").Replace("World", "C#");
            Console.WriteLine(sb.ToString());
        }
    }
}
