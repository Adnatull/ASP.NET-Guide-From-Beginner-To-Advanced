using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Constructor
{
    class Sum
    {
        public int x { get; set; }
        public Sum(int num)
        {
            x = num*2;
        }
        public Sum(int num1, int num2)
        {
            x = num1 + num2;
        }
    }
}
