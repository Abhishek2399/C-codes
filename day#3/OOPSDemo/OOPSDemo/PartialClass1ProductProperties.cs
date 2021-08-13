using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    // as rest of the class is in another file we need to use the word "partial" indicating the compiler that there is more of this class
    // rest of the class in file "PartialClass2ProductCustomization.cs"
    public partial class Product
    {
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public string GetProductDetails()
        {
            string details = string.Format($"Name : {ProductName}\nColor : {ProductColor}\nRate : {ProductRate}");
            return details;
        }


    }
}
