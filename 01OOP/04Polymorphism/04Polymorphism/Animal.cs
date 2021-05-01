using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Polymorphism
{
    public class Animal  // Base class (parent) 
    {
        public virtual string Name { get; set; } = "No Name";
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
