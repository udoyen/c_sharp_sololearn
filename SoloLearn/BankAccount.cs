using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double n)
        {
            balance += n;
        }

        public void Withdraw(double n)
        {
            balance -= n;
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
