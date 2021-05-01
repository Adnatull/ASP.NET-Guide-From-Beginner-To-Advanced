using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AccessModifiers
{
    public class Car
    {
        private string model1 = "Mustang";
        protected string model3 = "Toyota";

        public string model2 = "Ford";
        
        internal string model4 = "Tata";
    }

    public class DerivedCar : Car
    {
        public DerivedCar()
        {
            base.model3 = "Corola";
        }
        public string Type { get; set; }
        
    }
}
