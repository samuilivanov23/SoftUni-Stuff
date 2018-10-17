using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static double SumOfOdd_Even(int number)
        {
            if(number < 0)
            {
                number = Math.Abs(number);
            }
            int temp = 0;
            int oddSum = 0;
            int evenSum = 0;
            int finalResult = 0;
            while (number > 0)
            {
                temp = number % 10;
                if(temp % 2 == 0)
                {
                    evenSum += temp;
                }
                else
                {
                    oddSum += temp;
                }
                number /= 10;
            }
            finalResult = evenSum * oddSum;
            return finalResult;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfOdd_Even(number));
        }
    }
}
