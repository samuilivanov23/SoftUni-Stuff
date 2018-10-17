using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal surface = a * b;
            decimal perimeter = (2 * a) + (2 * b);
            decimal diagonal = Math.Sqrt((double)(a*a) + (double)(b*b));

        }
    }
}
