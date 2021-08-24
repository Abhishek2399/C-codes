using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class DelPracTest
    {
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static void GoodMoring(string name = "")
        {
            Console.WriteLine($"Good Morning {name}");
        }

        public static void GoodAfterNoon(string name = "")
        {
            Console.WriteLine($"Good After noon {name}");
        }


        static void Main()
        {
            DelegatePrac dp = new DelegatePrac();
            DelegatePrac.ArthDel arth = null;
            DelegatePrac.OnlyString os = null;


            // multicasting -> void type dels only 
            os = GoodMoring;
            os += dp.GoodNight;
            os += GoodAfterNoon;
            os -= GoodAfterNoon;

            os();

            arth = Mul;
            Console.WriteLine(Mul(5, 3));
            Console.WriteLine(arth(5, 3));

            arth = dp.Add;
            Console.WriteLine(arth(5, 3));
            arth = dp.Sub;

        }
    }
}
