using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OOPSDemo;
namespace DemoReflection
{
    class CustomAttrDemoInfoTest
    {
        static void Main()
        {
            Attribute[] attrs = Attribute.GetCustomAttributes(typeof(Pen));
            CustomAttrDemoInfo info = (CustomAttrDemoInfo)attrs[0];
            
            Console.WriteLine("------------------------------");
            foreach (CustomAttrDemoInfo attr in attrs)
            {
                Console.WriteLine($"Created by :\n\tName:{attr.Name}\n\tAge:{attr.Age}");
                Console.WriteLine($"Stored at : \n\t{attr.Path}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
