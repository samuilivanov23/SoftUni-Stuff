using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var kol = double.Parse(Console.ReadLine());
            if (town == "Sofiq")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(kol * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine(kol * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(kol * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(kol * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(kol * 1.60);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(kol * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(kol * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(kol * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(kol * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(kol * 1.50);
                }
            }
            else
            {
                if (product == "coffee")
                {
                    Console.WriteLine(kol * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(kol * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(kol * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(kol * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(kol * 1.50);
                }
            }
        }
    }
}
