using System;

namespace CSharpBasicsPractice
{
    // Creating interface
    internal interface IShape
    {
        double GetArea();
        void Display();
    }

    // Implement the interface in a struct
    public struct Square : IShape
    {
        public double Width { get; set; }   

        public Square(double width)
        {
            Width = width;
        }

        public double GetArea()
        {
            return Width*Width;
        }

        public void Display()
        {
            Console.WriteLine($"Square Area : {GetArea()}");
        }

        public class StructInterfaceDemo
        {
            public void Run()
            {
                IShape squ = new Square(5);
                squ.Display();

                //Struct still works as a value type
                Square s2 = new Square(5);
                s2.Display();
            }
        }
    }
}
