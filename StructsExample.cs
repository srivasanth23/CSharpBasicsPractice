using System;

namespace CSharpBasicsPractice
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point -> X: {X}, Y : {Y}");
        }
    }

    public struct Reactangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Reactangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area() => Width * Height;
    }

    public readonly struct Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display() => Console.WriteLine($"Coordinate → X: {X}, Y: {Y}");
    }

    // Struct demonstration Class
    public class StructDemo
    {
        public void Run()
        {
            Console.WriteLine("=== Struct Examples ===");

            //Basic struct usage
            Point p1 = new Point(10, 20);
            p1.Display();

            //Value type copy behaviour
            Point p2 = p1;
            p2.X = 99;
            Console.WriteLine("After modifying p2: ");
            p1.Display();
            p2.Display();

            //Struct with properties
            Reactangle rect = new Reactangle(5, 10);
            Console.WriteLine($"Rectangle Area: {rect.Area()}");

            //ReadOnly Struct usage
            Coordinate coord = new Coordinate(8, 10);
            coord.Display();
        }
    }
}
