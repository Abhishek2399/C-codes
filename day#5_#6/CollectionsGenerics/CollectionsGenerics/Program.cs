using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yes this is wokring ");
            MyCalendar mc = new MyCalendar();
            foreach(string day in mc) // can only be used if classes have implemented IEnumerable interface 
            {
                Console.WriteLine($"Day -> {day}"); // this is by-default getting us the days 
                // we need to explicitly write the method to get the months
            }
            Console.WriteLine();
            // Explicit Iteration calling
            foreach (string month in mc.GetMonths())
            {
                Console.WriteLine($"Month -> {month}");
            }
            Console.WriteLine();
            //WE can use foreach even on an array as array is a collection it has implemented the IEnumerable
            //eg:
            int[] arr = new int[3];
            arr[0] = 11;
            arr[1] = 27;
            arr[2] = 29;
            foreach(int num in arr)
            {
                Console.WriteLine($"Num -> {num}");
            }
            Console.WriteLine();

            Pen[] pens = new Pen[3];
            pens[0] = new Pen { Color = "Red", Rate = 2100 };
            pens[1] = new Pen { Color = "Black", Rate = 2710 };
            pens[2] = new Pen { Color = "Blue", Rate = 2990 };

            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"Rate:{pens[i].Rate} Color:{pens[i].Color}");
            }

            Console.WriteLine();
            foreach(Pen ipen in pens)
            {
                Console.WriteLine($"Rate:{ipen.Rate} Color:{ipen.Color}");
            }

        }

    }

}
