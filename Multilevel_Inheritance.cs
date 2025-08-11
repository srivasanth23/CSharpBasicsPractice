using System;

namespace BirdInheritanceExample
{
    // Base Class
    public class Bird
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Intermediate Derived Class
    public class FlyingBird : Bird
    {
        public FlyingBird(string name) : base(name) { }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying in the sky.");
        }
    }

    // Most Derived Class
    public class Eagle : FlyingBird
    {
        public Eagle(string name) : base(name) { }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting for prey.");
        }
    }
}
