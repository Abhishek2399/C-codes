using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3Soln
{
    class MainTest
    {
        static void Main()
        {
            Bird b = new Bird("Eagle", double.Parse("200"));
            b.fly();
            b.fly(double.Parse("300"));
        }
    }
}
