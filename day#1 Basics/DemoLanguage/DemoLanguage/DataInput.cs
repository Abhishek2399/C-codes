using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    class DataInput
    {
        static void Main()
        {
            string name; // string data type, name is a variable
            int age; // int data type, age is a variable 
            double mks;

            Console.WriteLine("Enter the name ");
            name = Console.ReadLine(); // Console.ReadLine returns string 
            
            Console.WriteLine("Enter the age ");
            age = Convert.ToInt32(Console.ReadLine()); // as Console.ReadLine returns string we need to convert it to int done by Convert.ToInt32

            Console.WriteLine("Enter the mks ");
            mks = Convert.ToDouble(Console.ReadLine()); // as Console.ReadLine returns string we need to convert it to int done by Convert.ToInt32


            // op - Name is -name- Age is -age-

            Console.WriteLine($"Name is {name} Age is {age}\nMarks {mks}"); // formatiing the string the way we want
            // $ : string interpolater to add variables in a string with the help of '{}' braces                                          

            Console.ReadLine();// just for stopping the program execution while running the builded application  file 
        }
    }
}
