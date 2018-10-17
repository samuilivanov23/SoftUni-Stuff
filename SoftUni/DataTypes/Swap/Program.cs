using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine($"Before:\n{a}\n{b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After:\n{a}\n{b}");
        }
    }
}
