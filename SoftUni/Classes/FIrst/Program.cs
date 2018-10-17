using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrst
{

    class BankAccounts
    {
        private string id;
        private double balance;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

    class Person
    {
        string name;
        int age;
        List<BankAccounts> accounts = new List<BankAccounts>();

        public List<BankAccounts> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public double GetBalance()
        {
            return accounts.Sum(x => x.Balance);
        }

        public int Age{
            get{ return age; }
            set{ age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
    
        }

        public void Present()
        {
            Console.WriteLine($"Hi, I am {name} and i am {age} years old!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccounts bankacc = new BankAccounts();
            bankacc.ID = "1";
            bankacc.Balance = 134.6;
            List<BankAccounts> account = new List<BankAccounts>();
            account.Add(bankacc);
            bankacc.ID = "2";
            bankacc.Balance = 230.5;
            account.Add(bankacc);
            Person Ivakisa = new Person();
            Ivakisa.Accounts = account;
            Ivakisa.Name = "Ivakis";
            Ivakisa.Age = 100;
            Console.WriteLine(Ivakisa.GetBalance());
            Ivakisa.Present();
        }
    }
}
