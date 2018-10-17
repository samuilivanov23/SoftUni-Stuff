using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sb = 0;
            int secondNum = 0;
            sbyte ThirdNum = 0;
            int temp = 0;
            if (num >= 0 && num <= sbyte.MaxValue)
            {
                sb = num;
                secondNum = int.Parse(Console.ReadLine());
                temp = 1;
            }
            else
            {
               ThirdNum = sbyte.Parse(Console.ReadLine());
               temp = 2;
            }
            if (temp == 1)
            {
                long result = (4 * sb) + (10 * secondNum);
                Console.WriteLine(result);
            }
            else if(temp == 2)
            {
                long result = (10 * num) + (4 * ThirdNum);
                Console.WriteLine(result);
            }
        }
    }
}
