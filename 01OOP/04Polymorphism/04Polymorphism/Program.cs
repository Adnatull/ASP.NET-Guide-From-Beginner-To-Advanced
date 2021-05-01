using System;

namespace _04Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dog = new Dog();
            Console.WriteLine(dog.Name);
            dog.AnimalSound();
            Console.ReadLine();
        }
    }
}
