using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string egn = Console.ReadLine();
            string uniqueNum = Console.ReadLine();
            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(egn);
            Console.WriteLine(uniqueNum);
        }
    }
}
