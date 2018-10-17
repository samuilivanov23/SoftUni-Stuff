using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class BankAccounts
    {
        public int id;
        public double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void WithDraw(double amount)
        {
            this.Balance -= amount;
        }
    }
}
