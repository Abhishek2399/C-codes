using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class PartialTest
    {
        static void Main()
        {
            Product watch = new Product { ProductColor = "Olive Green", ProductName = "Swiss-9000", ProductRate = 15000 }; // creating the product obj
            Console.WriteLine(watch.GetProductDetails()); // getting the detials from method present in the file "PartialClass1ProductProperties"
            watch.ChangeProductColor("Aqua Blue"); // changing the properties of the object from partial class present in "PartialClass2ProductCustomization"
            watch.ChangeProductName("Swiss-9500"); // here because it is partial we are able to use properties/methods being defined in the different physical file locations 
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(watch.GetProductDetails());// getting the detials from method present in the file "PartialClass1ProductProperties"
        }
    }
}
