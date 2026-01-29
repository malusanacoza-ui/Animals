using System;

namespace Animals
{
    public class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing a tree!");
        }
    }
}
