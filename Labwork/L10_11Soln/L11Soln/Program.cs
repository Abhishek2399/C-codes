using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Soln
{
    class Program
    {
        public static void Notification(string msg)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(msg);
            Console.WriteLine("------------------------------------------");

        }

        static void Main(string[] args)
        {
            try
            {
                CreditClass abhi = new CreditClass(name: "abhi", cardNo: 127, balance: 250000);
                CreditClass rahul = new CreditClass(name: "rahul", cardNo: 129, balance: 250000);
                CreditClass.PaymentHandler payHandle = Notification; // for raising the event, what to do when the event is raised 
                
                abhi.PaymentEvent += payHandle; // subscribing for the event
                abhi.MakePayment(200);

                rahul.MakePayment(2600);

                abhi.MakePayment(200);

                abhi.MakePayment(2890);
                
                abhi.MakePayment(200);
                
                abhi.MakePayment(200);
                
                abhi.MakePayment(200);


            }
            catch (Exception ex)
            {
                
            }
        }
    }

}
