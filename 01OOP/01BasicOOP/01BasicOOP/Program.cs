using System;

namespace _01BasicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person();
            person1.FirstName = "Mohi";
            person1.LastName = "Shamim";
            person1.Age = 26;
            Console.WriteLine(person1.FullName());

            Person person2 = new Person();
            person2.FirstName = "Al";
            person2.LastName = "Masum";
            person2.Age = 26;
            Console.WriteLine(person2.FullName());

            Console.WriteLine("Enter Two numbers separated by new line");

            Calculator calculator1 = new Calculator();

            calculator1.X = Convert.ToInt32(Console.ReadLine());
            calculator1.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summation is: " + calculator1.Sum());
            Console.WriteLine("Subtraction is: " + calculator1.Subtraction());
            Console.WriteLine("Multiplication is: " + calculator1.Multiplication());
            Console.WriteLine("Division is: " + calculator1.Division());

            Console.ReadLine();

        }
    }
}
