using System;

namespace _02Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sum X = new Sum(10,20);
            Console.WriteLine(X.x);
        }
    }
}
