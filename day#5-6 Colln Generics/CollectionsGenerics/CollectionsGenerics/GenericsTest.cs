using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    // Generic is a concept for type security, for getting only specific type of data 
    // Syntax :- gen_name{class, method, delegates, interfaces} <T>{'T' can use anything instead of T} 
    class GenericsTest
    {

        static void Swap(ref int a, ref int b) // for int type data 
        {
            int temp = a;
            a = b;
            b = temp;
        }
        // similarly for different data types diff methods this can be solved by generics 
        // to solve this we can create a generic mthod 
        static void Swap<T>(ref T a, ref T b) // one method works with different data types
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            int a = 10, b = 21;
            float fa = 11.24f, fb = 99.97f;
            string name = "Bhovar", surname = "Abhi";

            Console.WriteLine($"a->{a} b->{b}");
            Swap(ref a, ref b);// calling the int Swap
            Console.WriteLine($"a->{a} b->{b}");
            // calling the generic Swap
            
            Console.WriteLine($"Name : {name} Surname : {surname}");
            Swap(ref name, ref surname); // similar to how we call a normal method 
            Console.WriteLine($"Name : {name} Surname : {surname}");

            Console.WriteLine($"Fa : {fa} Fb: {fb}");
            Swap(ref fa, ref fb); // similar to how we call a normal method 
            Console.WriteLine($"Fa : {fa} Fb: {fb}");

            //Swap(ref name, ref a); // following will give an error as the data type the Swap is accepting should be of same type 
            // following concept is known as type checking 

            // we can generic to take different datatypes as methodname<T, U> (T a, U b)
            // while calling we send the data types methodname<int, int[]>(var1, var2)
            // while calling we send the data types methodname<string, string[]>(var1, var2)
            // while calling we send the data types methodname<int, string>(var1, var2)




        }
    }
}
