using System;

namespace CSharpBasicsPractice
{
    public class Arrays
    {
        public void RunExamples()
        {
            //Using new keyword
            string[] names = new string[] { "Srivasanth", "Bob", "Sriram" };

            // 1D array         //Array declartion with values
            int[] marks = { 80, 30, 40, 23, 40 };
            Console.WriteLine();

            //Array Methods 
            Array.Sort(marks);
            Console.WriteLine("Sorting: ");
            foreach (var m in marks) Console.Write(m + " ");
            Console.WriteLine();

            // Array reveresing 
            Array.Reverse(marks);
            Console.WriteLine("Reversing :");
            foreach (var m in marks) Console.Write(m + " ");
            Console.WriteLine();

            Console.WriteLine("Index of 40: " + Array.IndexOf(marks, 40));

            //Slicing is supportable in (C# 8+)
            int[] slice = marks[1..4];
            Console.WriteLine("Slice (1..4)");
            foreach(var s in slice) Console.WriteLine(s + " ");
            Console.WriteLine();

            //2D array 
            int[,] matrix = { { 2, 3, 4 }, { 5, 6, 7 } };
            Console.WriteLine("2D array: ");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
                Console.WriteLine(' ');
            }

            //Jagged Array
            int[][] jagged = new int[2][];
            jagged[0] = new int[] { 1, 1, 3 };
            jagged[1] = new int[] { 4, 5 };
            Console.WriteLine("Jagged Array:");

            for(int i =0; i < jagged.GetLength(0); i++)
            {
                for(int j = 0; j < jagged[1].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine() ;
            }
        }

    }
}
