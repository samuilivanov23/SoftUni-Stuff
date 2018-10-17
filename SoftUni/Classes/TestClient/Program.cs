using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{

    class BankAccount
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

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> dict = new Dictionary<int, BankAccount>();
            BankAccount account = new BankAccount();
            List<string> input = new List<string>();
            do
            {
                input = Console.ReadLine().Split(' ').ToList();
                switch (input[0])
                {
                    case "Create":
                        if (!dict.ContainsKey(int.Parse(input[1])))
                        {
                            account.ID = int.Parse(input[1]);
                            dict.Add(int.Parse(input[1]), account);
                        }
                        else
                        {
                            Console.WriteLine("Account already exists!");
                        }
                        break;

                    case "Deposit":
                        if (dict.ContainsKey(int.Parse(input[1])))
                        {
                            dict[int.Parse(input[1])].Deposit(double.Parse(input[2]));
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist!");
                        }
                        break;

                    case "Withdraw":
                        if (dict.ContainsKey(int.Parse(input[1])))
                        {
                            if (!(dict[int.Parse(input[1])].balance < double.Parse(input[2])))
                            {
                                dict[int.Parse(input[1])].WithDraw(double.Parse(input[2]));
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        break;

                    case "Print":
                        Console.WriteLine($"Account ID{account.id}, balance {account.balance.ToString(".00")}");
                        break;
                }
            }
            while (input[0] != "End");
        }
    }
}
