using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Print(int n)
        {
            var width = n * 5;
            var height = n * 3 + 2;
            Console.Write(new string('.', n));
            Console.Write(new string('*', n * 3));
            Console.Write(new string('.', n));
            Console.WriteLine();

            for (int i = n-1; i > 0; i--)
            {
                var numOuterDots = i;
                var numInnerDots = width - 2 - 2 * numOuterDots;
                Console.Write(new string('.', numOuterDots));
                Console.Write("*");
                Console.Write(new string('.', numInnerDots));
                Console.Write("*");
                Console.Write(new string('.', numOuterDots));
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', width));

            for(int i = 1; i <= 2*n; i++)
            {
                var numOuterDots = i;
                var numInnerDots = width - 2 - 2 * numOuterDots;
                Console.Write(new string('.', numOuterDots));
                Console.Write("*");
                Console.Write(new string('.', numInnerDots));
                Console.Write("*");
                Console.Write(new string('.', numOuterDots));
                Console.WriteLine();
            }
            var numOuterDots_ = (width - (n - 2)) / 2;
            Console.Write(new string('.', numOuterDots_));
            Console.Write(new string('*', n - 2));
            Console.WriteLine(new string('.', numOuterDots_));
        }
        static void Main(string[] args)
        {
            Print(4);
        }
    }
}
