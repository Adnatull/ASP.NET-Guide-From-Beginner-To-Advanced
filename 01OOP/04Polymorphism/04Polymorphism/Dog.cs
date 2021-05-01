using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Polymorphism
{
    public class Dog : Animal
    {
        public override string Name { get; set; } = "Dog";

        public override void AnimalSound()
        {
            Console.WriteLine("The Dog makes a sound");
        }

    }
}
