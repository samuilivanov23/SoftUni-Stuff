using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHeckingNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result = Math.Abs(num1 - num2);
            if(result > 0.000001)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
                Console.WriteLine(result);
            }
        }
    }
}
