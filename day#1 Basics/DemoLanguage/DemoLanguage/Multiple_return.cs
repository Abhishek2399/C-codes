using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    
    class Multiple_return
    {
        private static void Mycalc_multi(int a, int b, out int c, out int d) // using "out" as a variables going outside the function and bydefault if not specified they are in variables
        {
            c = a + b;
            d = a * b;
        }

        private static void Mycalc_ref(int a, int b, ref int x, ref int y) // performing the same functionality as above using reference variable instead of out 
        {
            x = a + b;
            y = a * b;
        }


        static void Main()
        {
            int a = 9, b = 10;
            int c, d;// declare is also okay 
            int error_c, error_d;
            int x=0, y=0; // declare + initialize complusory for ref
            
            Mycalc_multi(a, b, out c, out d);
            Console.WriteLine($"Multi op-> {a} {b} {c} {d}");

            Mycalc_ref(a, b, ref x, ref y);
            Console.WriteLine($"Reff op-> {a} {b} {x} {y}");

            // difference between "ref" and "out"

            // passing c, d as ref to the multi_ref we get an error 
            
            /* uncommenting following instrn will show the error -> 
            Mycalc_ref(a, b, out error_c, out error_d); 
            */

            // as error_c and error_d are not initialised we can't pass them as ref. variable ref. variable should always be initialised it is okay if "out" is not initialised 

        }


    }
}
