using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ExtensionTest
    {
        static void Main()
        {
            string name = "Abhi";
            int num = 11;
            Console.WriteLine(name.MyWordCount()); // name is an string object, string class is not having the MyWordCount method we have extended the functionality of the string class 
            Console.WriteLine(num.OddEven());
            Console.WriteLine(name.OddEven());
            string phone = "123-456-789";
            Console.WriteLine(phone.FormatContact());
            // --------------- Working with the self made classes like Pen --------------------------------
            Pen parkor = new Pen { Rate = 200, Color = "Aqua Blue" };
            Console.WriteLine(parkor.PenDiscount(3));
        }

    }
}
