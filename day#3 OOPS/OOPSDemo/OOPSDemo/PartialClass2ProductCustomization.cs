using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    // as rest of the class is in another file we need to use the word "partial" indicating the compiler that there is more of this class
    // rest of the class in file "PartialClass2ProductProperties.cs"

    partial class Product
    {
        public int ProductRate { get; set; }

        public void ChangeProductColor(string color)
        {
            this.ProductColor = color;
        }
        public void ChangeProductName(string name)
        {
            this.ProductName = name;
        }

    }
}
