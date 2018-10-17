using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(
               new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\");
                Console.Write("/");
            }
            Console.WriteLine('-');
        }

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintHeaderRow(size);
            for (int i = 0; i < size - 2; i++)
            {
                PrintMiddleRow(size);
            }
            PrintHeaderRow(size);
        }
    }
}
