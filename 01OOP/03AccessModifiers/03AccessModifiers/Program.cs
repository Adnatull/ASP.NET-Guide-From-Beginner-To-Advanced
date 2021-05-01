using System;


namespace _03AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var car = new Car();
            Console.WriteLine(car);
            var dcar = new DerivedCar();

        }
    }
}
