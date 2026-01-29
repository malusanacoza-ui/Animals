using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Dog object
            Dog dog1 = new Dog("Buddy", 3, "Labrador");
            dog1.MakeSound();
            dog1.Eat();
            dog1.Fetch();

            Console.WriteLine();

            // Create Cat object
            Cat cat1 = new Cat("Whiskers", 2, "Black");
            cat1.MakeSound();
            cat1.Eat();
            cat1.Climb();

            Console.ReadLine();
        }
    }
}
