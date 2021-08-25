using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Soln
{
    class CreditClass
    {
        public int CreditCardNo { get; set; }
        public string CardHolderName { get; set; }
        public int BalanceAmount { get; set; }
        public static int creditLimit = 2500 ;

        public int GetBalance()
        {
            return BalanceAmount;
        }

        public int GetCreditLimit()
        {
            return creditLimit;
        }

        public int MakePayment(int amount)
        {
            if (amount < creditLimit)
            {
                BalanceAmount -= amount;
                if (PaymentEvent != null)
                    PaymentEvent($"Payment of {amount}.rs Done");
                return amount;
            }
            else
            {
                throw new Exception("Credit Limit Exceeded");
            }
        }

        public delegate void PaymentHandler(string msg);

        public event PaymentHandler PaymentEvent;
    }
}
