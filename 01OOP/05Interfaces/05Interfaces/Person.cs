using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Interfaces
{
    public class Person : IPerson
    {
        public string Name()
        {
            return "Shamim";
        }
    }
}
