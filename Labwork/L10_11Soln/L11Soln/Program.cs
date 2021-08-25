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
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            try
            {
                CreditClass abhi = new CreditClass(name: "abhi", cardNo: 127, balance: 250000);
                Console.WriteLine(CreditClass.creditLimit);
                CreditClass.PaymentHandler payHandle = Notification; // for raising the event
                abhi.PaymentEvent += payHandle; // subscribing for the event
                abhi.MakePayment(2600);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
