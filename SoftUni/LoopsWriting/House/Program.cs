using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                var starNum = 2;
                for (int row = 1; row <= (n + 1)/2; row++)
                {
                    if (row == 1)
                    {

                        Console.Write(new string('-', (n - starNum) / 2));
                        Console.Write(new string('*', starNum));
                        Console.Write(new string('-', (n - starNum) / 2));
                    }
                    else
                    {
                        starNum += 2;
                        Console.Write(new string('-', (n - starNum) / 2));
                        Console.Write(new string('*', starNum));
                        Console.Write(new string('-', (n - starNum) / 2));
                    }
                    Console.WriteLine();
                }

                for (int row = 1; row <= n/2; row++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n-2));
                    Console.Write("|");
                    Console.WriteLine();
                }
            }

            else
            {
                var starNum = 1;
                for (int row = 1; row <= (n+1)/2; row++)
                {
                    if (row == 1)
                    {

                        Console.Write(new string('-', (n - starNum) / 2));
                        Console.Write(new string('*', starNum));
                        Console.Write(new string('-', (n - starNum) / 2));
                    }
                    else
                    {
                        starNum += 2;
                        Console.Write(new string('-', (n - starNum) / 2));
                        Console.Write(new string('*', starNum));
                        Console.Write(new string('-', (n - starNum) / 2));
                    }
                    Console.WriteLine();
                }

                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
        }
    }
}
//n/2-1;