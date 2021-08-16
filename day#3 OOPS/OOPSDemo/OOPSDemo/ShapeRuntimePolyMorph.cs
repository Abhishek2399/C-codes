using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ShapeRuntimePolyMorph
    {
        public virtual void CalArea()
        {
            Console.WriteLine("Shape Area is Calculated \n");
        }
    }

    class Circle : ShapeRuntimePolyMorph
    {
        public int Radius { get; set; }
        public override void CalArea()
        {
            float area = (float)(Math.PI * Radius * Radius); // Math.PI returns double hence we require float type casting
            Console.WriteLine($"Area of Circle is {area}\n");
        }
    }

    class Rectangle : ShapeRuntimePolyMorph
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public override void CalArea()
        {
            int area = Length * Breadth;
            Console.WriteLine($"Area of Rectangle is {area}\n");

        }
    }


}
