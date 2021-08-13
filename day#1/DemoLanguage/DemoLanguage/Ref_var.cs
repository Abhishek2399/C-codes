using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class Ref_var
    {
        private static void SwapByVal(int a, int b) // pass by value 
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void SwapByRef(ref int a, ref int b) // using ref var to get the ref variable 
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void ChangeNos(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                a[i] *= 10;
            }
        }
        private static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"arr[{i}] -> {a[i]}");
            }
        }



        public static void Main()
        {
            int a = 4, b = 6;
            Console.WriteLine($"a->{a} b->{b}");
            
            SwapByVal(a, b); 
            Console.WriteLine($"a->{a} b->{b}");

            SwapByRef(ref a, ref b); // using "ref" keyword to send the reference of variable 
            Console.WriteLine($"a->{a} b->{b}");

            int[] arr = { 12, 11, 34, 56 };
            PrintArr(arr);
            ChangeNos(arr);
            PrintArr(arr);
        }
    }
}
