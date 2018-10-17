using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccounts account = new BankAccounts();
            List<BankAccounts> acc = new List<BankAccounts>();
            account.ID = 1;
            account.Balance = 150.0;
            acc.Add(account);
            account = new BankAccounts();
            account.ID = 2;
            account.Balance = 75.0;
            acc.Add(account);
            Person person = new Person("Ivakis", 100, acc);
            Console.WriteLine($"person name: {person.name}");
            Console.WriteLine(person.GetBalance());

        }
    }
}
