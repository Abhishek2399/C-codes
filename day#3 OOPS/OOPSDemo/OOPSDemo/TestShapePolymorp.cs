using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class TestShapePolymorp
    {
        static void Main()
        {
            /*
            Shape ss = new Shape();
            ss.CalArea();
            
            ss = new Rectangle { Length = 17, Breadth = 19 }; // chanign the shape object to Rectangle 
            ss.CalArea();

            ss = new Circle{ Radius = 19 };// chanign the shape object to Rectangle 
            ss.CalArea();
            */
            ShapeRuntimePolyMorph ss = new Rectangle { Length = 34, Breadth = 39};
            show(ss); // as ss is a Rectangle type obj we will get area of rectangle
            ss = new Circle { Radius = 37 };
            show(ss);


        }

        public static void show(ShapeRuntimePolyMorph shape) // Shape object can be a Rectangle or a Circle as per the object passed we will get the area
        {
            // this is runtime polymorphism as this is changing in accordance with the object 
            Console.WriteLine($"Area : \n");
            shape.CalArea();
        }
    }
}
