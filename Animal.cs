using System;

namespace Animals
{
    public class Animal
    {
        // Properties (what an animal has)
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor (runs when object is created)
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method (what an animal can do)
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
