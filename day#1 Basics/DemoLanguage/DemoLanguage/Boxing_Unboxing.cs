using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class BoxingDemo
    {
        // declaration and intialization 
        // stack heap code  . . 
        // ref_t -> object strings

        public static void Main()
        {
            int x = 10; // value type in stack
            object oo; // reference type declared in stack
            oo = x; //  value type stored into reference type aka "Boxing"
            Console.WriteLine(oo);
            x = 20;
            Console.WriteLine(oo);
            int y = Convert.ToInt32(oo); // "Unboxing" of data since we are storing ref_t which is obj_type in int_t we have to type cast
            Console.WriteLine("Y "+y);
            oo = 100;
            Console.WriteLine("Y new "+y);

            int age; //declare
            age = 21; //init
            
            float mks = 12.4f;

            object oAge; // declare
            oAge = 21; // init
            oAge = "abhi";
            oAge = 12.34f;
            oAge = 12.3;


            age = 22;
            oAge = 22; // init


            int age2 = age;
            age2 = Convert.ToInt32(oAge);


            // limitation ref var 
            // no memory control and wastage of mem
            // constant type csting 





        }
    }
}
