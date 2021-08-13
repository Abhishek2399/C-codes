using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Saving : Customer
    {
        public int MinBalance { get; set; }
        public override void Deposit(int amount)
        {
            Balance += amount;
        }
        public override void Withdraw(int amount)
        {
            if (Balance < MinBalance || amount > Balance)
            {
                throw new Exception("Low Balance");
            }
            else
            {
                Balance -= amount;
            }
        }

    }
}
