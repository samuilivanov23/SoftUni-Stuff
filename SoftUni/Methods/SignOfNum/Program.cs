using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfNum
{
    class Program
    {
        static void Sign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Sign(num);
        }
    }
}
