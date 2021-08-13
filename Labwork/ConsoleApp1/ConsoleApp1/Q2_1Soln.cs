using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Q2_1Soln
    {
        // totally similar to classes

        struct SingleNum
        {
            public int Num { get; set; }

            public int Square()
            {
                return Num*Num;
            }

            public int Cube()
            {
                return Num * Num * Num;
            }


        }
        static void Main()
        {
            SingleNum num = new SingleNum();
            num.Num = 3;
            Console.WriteLine(num.Square());
            Console.WriteLine(num.Cube());

        }
    }
}
