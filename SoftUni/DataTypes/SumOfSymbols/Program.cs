using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            char ch;
            for (int i =0; i < n; i++)
            {
                ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine(sum);
        }
    }
}
