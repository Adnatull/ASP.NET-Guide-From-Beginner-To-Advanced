using System;

namespace _05Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPerson person = new Person();
            Console.WriteLine(person.Name());
            Console.ReadLine();
        }
    }
}
