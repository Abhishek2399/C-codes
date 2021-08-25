using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Soln
{
    class Program
    {
        public void Notification(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            CreditClass abhi = new CreditClass();
            Console.WriteLine(CreditClass.creditLimit);
        }
    }

}
