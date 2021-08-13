using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    abstract public class Customer
    {
        public int CusNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        abstract public void Deposit(int amount);
        abstract public void Withdraw(int amount); // abstract methods can never be private


    }
}
