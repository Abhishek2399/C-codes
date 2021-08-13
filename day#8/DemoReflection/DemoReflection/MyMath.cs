using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflection
{
    class MyMath
    {
        public int Fno { get; set; }
        public int Sno { get; set; }

        public int Add()
        {
            return Fno + Sno;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

    }
}
