using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Enum
    {
        // enum -> enumeration this is a set of named integer constants 
        // each value inside any enum will represent an integer 
        // the default start value in enum is 0
        enum DefaultDays { Sun, Mon, Tue, Wed, Thu, Fri, Sat}; // every element inside the {} is sort of like an int var and as no start value given to very first Var. ti is taken as 0 hence Sun will be 0
        enum Colors { Red, Green, Blue, White, Black, Orange, Pink, Violet }; // enum is just use to represent some info not for data storage 
        // Enum is Hard Coded

        enum DefinedDays { Sun=1, Mon, Tue, Wed, Thu, Fri, Sat }; //  we can give the start value and others will have values incremented by one '1'
        enum Months {Jan= 1, Feb, Mar, April, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }; //  we can give any value in between and the rest of the values after that will be incremented from that value 
        // Note : Numbering should not be duplication  

        static void Main()
        {
            
            
            Console.WriteLine(DefaultDays.Sun); // This will give the element name itself Sun
            Console.WriteLine(DefaultDays.Mon); // Mon
            Console.WriteLine(DefaultDays.Sat); // Sat

            Console.WriteLine((int)DefaultDays.Sun); // 0 typecasting will give us the value stored 
            Console.WriteLine((int)DefaultDays.Mon); // 1 
            Console.WriteLine((int)DefaultDays.Sat); // 6 

            Console.WriteLine((int)DefinedDays.Sun); // 1 as we have given it 1
            Console.WriteLine((int)DefinedDays.Mon); // 2
            Console.WriteLine((int)DefinedDays.Sat); // 7 
            


            Console.WriteLine(DefinedDays.Sun +" "+(int)DefinedDays.Sun); //  sun 1 
            Console.WriteLine(DefinedDays.Mon + " " + (int)DefinedDays.Mon); // mon 2 
            Console.WriteLine(DefinedDays.Sat + " " + (int)DefinedDays.Sat); // sat 7 

            Console.WriteLine(Months.Jan + " " + (int)Months.Jan); // as we have given 1 it is 1, if nothing was given it would have continued after the value of Sat i.e. 7
            Console.WriteLine(Months.April + " " + (int)Months.April); //april  4
            Console.WriteLine(Months.Dec + " " + (int)Months.Dec); // dec 12 




        }
    }
}
