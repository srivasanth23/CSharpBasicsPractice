using System;


namespace CSharpBasicsPractice
{
    // Base class
    public class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }
    }

    // Derived class
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int doors) : base(brand)
        {
            NumberOfDoors = doors;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Doors: {NumberOfDoors}");
        }
    }
}
