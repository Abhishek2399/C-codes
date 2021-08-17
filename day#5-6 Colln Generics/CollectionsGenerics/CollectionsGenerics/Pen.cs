using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    class Pen : IComparable // interface containing ToCompare method which compares two obj 
    {
        #region Basic Codes
        public int Rate { get; set; }
        public string Color { get; set; }

        public override string ToString() //  make a habbit to overwrite the ToString because only if we call the object by default it will call thi sToString and we can get the information we want 
        {
            return $"---------------------\nPen:\nRate : {Rate}  Color :{Color}\n-------------------\n";
        }

        public int CompareTo(object obj)
        {
            Pen p = obj as Pen;
            return string.Compare(this.Color, p.Color);
        }

        public int Add(object other)
        {
            Pen otherPen = other as Pen; // converting one object to other 
            return this.Rate + otherPen.Rate;
        }
        #endregion

        #region Delegate and Event 
        // Delegate related code
        // following methods were used for testing of delegate 
        public void Add(int a, int b)
        {
            Console.WriteLine($"(a){a} + (b){b} = {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"(a){a} - (b){b} = {a - b}");
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine($"(a){a} * (b){b} = {a * b}");
        }
        public void Div(int a, int b)
        {
            Console.WriteLine($"(a){a} / (b){b} = {a / b}");
        }

        // MySort testing 
        public bool ColorSort(Pen data, Pen data2) // sorting by color code
        {
            return string.Compare(data.Color, data2.Color) < 0; // checking is data smaller than data1
        }

        public bool RateSort(Pen data, Pen data2)
        {

            return (data.Rate - data2.Rate) > 0;
        }


        // Delegate and Event 
        public delegate void RateHandler(string msg); // delegate to display the event msgs

        public event RateHandler RateChange; // Defining the event i.e. for the change of Rate

        public void NewRate(int rate)
        {
            int oldRate = this.Rate;
            Console.WriteLine("Rate has been changed");
            this.Rate = rate;
            if (RateChange != null)// as the event has not been handeled the RateChange is not yet null
                RateChange($"Rate Changed from {oldRate} to {rate}"); // Raising the event 
        }


        #endregion
    }
}
