using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Overload
    {
        // backing field
        private decimal _balance;

        // parameterized constructer 
        public Overload(decimal StartingBalance)
        {
            _balance = StartingBalance;

        }

        // balance property (read only)
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        // method deposit
        public void Deposit(decimal amount)
        {
            _balance += amount;

        }

        // method withdraw
        public void Withdraw(decimal amount)
        {
            _balance -= amount;

        }
    
}
}
