using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class DelegatePrac
    {
        // return type, no of params, type of params should be same as the function it would be holding
        // add, mul, sub, div
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public void GoodNight(string name = "")
        {
            Console.WriteLine($"Good Night {name}");
        }

        public delegate int ArthDel(int a, int b);
        public delegate void OnlyString(string someData = "");

    }
}
