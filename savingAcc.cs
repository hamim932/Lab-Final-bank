using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp
{
    class Savings : Account
    {
        int MaxNumOfTransaction;

        public Savings() : base()
        {
            MaxNumOfTransaction = 10;
        }
        public Savings(string name, int? accNo, double balance) : base(name, accNo, balance)
        {
            MaxNumOfTransaction = 100;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500 && numOfTransaction <= MaxNumOfTransaction)
            {
                Balance -= amount;
                numOfTransaction++;
            }
            else
            {
                Console.WriteLine("The Amount is exceeds in the minimum balance");
            }
        }
    }
}