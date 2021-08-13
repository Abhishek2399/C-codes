using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductDemo
    {
        private object prodID;
        private object name;
        private object price;
        private object quantity;
        
        public int ProdID
        {
            get { return Convert.ToInt32(prodID); }
            set { prodID = value; }
        }
        
        public string Name
        {
            get { return name.ToString(); }
            set { name = value; }
        }
        
        public double Price
        {
            get { return Convert.ToDouble(price); }
            set { price = value; }
        }
        
        public double Quantity
        {
            get { return Convert.ToDouble(quantity); }
            set { quantity = value; }
        }

        public double AmountPayable()
        {
            double toPay = Price * Quantity;
            return toPay;
        }

        public override string ToString()
        {
            string info = $"Product Details:\nProduct Name : {Name}\nProduct ID : {ProdID}\nPrice : {Price}\nQuantity : {Quantity}\nAmount Payable : {AmountPayable()}";
            return info;
        }

    }

    class Q2_4Soln
    {
        static void Main()
        {
            ProductDemo product = new ProductDemo();
            product.Name = "pens";
            product.ProdID = 217;
            product.Price = 217;
            product.Quantity = 21;
            Console.WriteLine(product);
        }
    }
}
