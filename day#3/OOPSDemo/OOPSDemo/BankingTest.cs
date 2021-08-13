using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace OOPSDemo
{
    class BankingTest
    {
        static void Main()
        {
            Saving s = new Saving { CusNo = 123, Name = "Tom", Balance = 10000, MinBalance = 1000 };
            try
            {
                s.Deposit(5000);
                Console.WriteLine(s.Balance);
                s.Withdraw(15000);
                Console.WriteLine(s.Balance);
                s.Withdraw(500);
                Console.WriteLine(s.Balance);
                s.Deposit(2500);
                Console.WriteLine(s.Balance);
                s.Withdraw(14500);
                Console.WriteLine(s.Balance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
