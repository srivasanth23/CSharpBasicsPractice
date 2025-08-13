using System;

namespace CSharpBasicsPractice
{
    class TestEmployeeIndexers
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(1, "Srivasanth", 200000, "Manager", "ASE", "Mumbai");
            Console.WriteLine(Emp[0]);
            Console.WriteLine(Emp[1]);
            Console.WriteLine(Emp[2]);
            Console.WriteLine(Emp[3]);
            Console.WriteLine(Emp[4]);
            Console.WriteLine(Emp[5]);

            Emp[0] = 1220;
            Console.WriteLine(Emp[0]);
        }
    }
}
