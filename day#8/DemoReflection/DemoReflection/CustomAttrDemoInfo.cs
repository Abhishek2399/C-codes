using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoReflection
{
    // demo for creating custom attributes
    // then we have to define the attribute usage
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] // Attribute will traget a Class i.e. it will be used on any type of class
                                                                   // allow mutiple is for letting the compiler know that this can be used multiple time 

    class CustomAttrDemoInfo : Attribute // for creating a cutom attribute class we have to extend the class Attribute 
    {
        // properties are the information that we want to give about the class
        // it can be file name, full name, path, project name 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Path { get; set; }


    }
}
