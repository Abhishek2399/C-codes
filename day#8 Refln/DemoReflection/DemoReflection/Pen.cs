using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoReflection; // this is where the custom attr. "CustomAttrDemoInfo" is stored
using System.IO;

namespace OOPSDemo
{
    [CustomAttrDemoInfo(Name = "Abhi", Age = 21, Path = @"D:\capgemini\training\technical\day#8\DemoReflection\DemoReflection\Pen.cs")]
    [CustomAttrDemoInfo(Name = "Sudhir", Age = 29, Path = @"D:\capgemini\training\technical\day#8\DemoReflection\DemoReflection\Pen.cs")] // this is the allow mutliple use , we have used same attr for a single class twice 
    class Pen // by default access modifier is "Internal" can be used in the same assembly(single .exe/.dll)
    {
        //-----------------------------------------------------------------
        // below elements are associated with every created obj. inidividually, i.e. different value for diff. obj.
        // elements are by default private 
        private int rate; // element of the class Pen i.e. rate of the pen, every element associated to obj should always "always" be private 
        private string color; // aka instance element 
         //-----------------------------------------------------------------

        //-----------------
        private static int count; // static is shared variable between different instances, common for every object 
        // def. initialization is 0
        //-----------------

        //-----------------------------------------------------------------
        // Element should only be accessed by properties 
        //Property - Code block containing both the getter and setter 
        public int Rate // name of Property should be same as the element it is related to, Naming Convention is Capitalize element name
        {
            get { return rate; } // getter, returns the element 
            set { rate = value; } // setter, sets a value to the element "value" is a keyword here 
        }

        public string Color
        {
            get { return color; } // getter, returns the element 
            set { color = value; } // setter, sets a value to the element "value" is a keyword here 
        }
        //-----------------------------------------------------------------
        
        //-----------------------------------------------------------------
        // Following class already has a default constructor 
        // we can define our own in the following way given below :-
        //Consider we want a Constructor to set the rate and color of every pen object created 

        // will be called when object is created 
        public Pen() // Non parameterized 
        {
            // I am using this as default rate and color for every pen object 
            rate = 10;
            color = "red";
            count++; // every time object created and details set the pen count will increment 
        }

        // instead of default element values we can use parameterized constr to set our own values or the Property to set the value
        // will be called when object is created 
        public Pen(int rate, string color) // parameterized constructor 
        {
            this.rate = rate; // "this." only when the parameter name and the properties on the class have same name/identifier here the "rate" is the parameter passed where as the "this.rate"  
            this.color = color;
            count++; // every time object created and details set the pen count will increment 
        }

        // static Constructor 
        // will be called when class in referenced
        static Pen() // will be called when very frist time the "class" has been referenced no matter a static method from class
        {
            // initialise the static variables
            count = 0;
        }
        //-----------------------------------------------------------------

        //-----------------------------------------------------------------
        // Let's create a method to return the fromatted information of the pen object, here the details contains the rate and color of pen 
        // signtaure { return_t : string, Params : None}
        // following is an instance method i.e. it is associated to every instance of class(obj.) 
        public string GetDetails()
        {
            string details = string.Format($"Color of the pen -> {color}\nRate of the pen -> {rate}"); // can directly send this string inside Format methodd we can return directly the passed parameter to .Format, but always a good way to send data in variable
            return details;
        }
        //-----------------------------------------------------------------

        //-----------------------------------------------------------------
        // static method
        // unlike instance this is associated to the class itself
        // called/referenced by the class_name i.e. Pen 
        public static int ShowCount() 
        {
            return count;
        }

        public override string ToString()
        {
            string info = $"Color:{Color}\nRate:{Rate}";
            return info;
        }

        [Obsolete("this method is outdated")]
        public string ShowPen()
        {
            string info = $"Color:{Color}\nRate:{Rate}";
            return info;
        }

        //-----------------------------------------------------------------

    }
    // signature of Pen class {elements : (rate,color), property : (Rate, Color), Constr : (def., Non-Param, Param), Method : (GetDetails)}
}
