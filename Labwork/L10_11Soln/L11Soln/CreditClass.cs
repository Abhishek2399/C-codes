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

        public CreditClass(string name, int cardNo, int balance)
        {
            CreditCardNo = cardNo;
            CardHolderName = name;
            BalanceAmount = balance;
        }


        public int GetBalance()
        {
            return BalanceAmount;
        }

        public int GetCreditLimit()
        {
            return creditLimit;
        }

        public void MakePayment(int amount)
        {
            if (amount < creditLimit)
            {
                BalanceAmount -= amount;
                if (PaymentEvent != null)
                    PaymentEvent($"Card Holder : {CardHolderName} \nPayment of {amount}.rs Done\nBalance : {BalanceAmount}");
            }
            else
            {
                if(PaymentEvent != null)
                    PaymentEvent($"Card Holder : {CardHolderName}\nError : Credit Limit Exceeded");   
            }
        }

        public delegate void PaymentHandler(string msg); // delegate to hold function used to raise event 

        public event PaymentHandler PaymentEvent; // event has to be of type delegate 
    }
}
