using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chislo_S_Dumi
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus += 5;
                if (num % 2 == 0)
                {
                    bonus += 1;
                }
                else if (num % 10 == 5)
                {
                    bonus += 2;
                }
                num += bonus;
            }
            else if(num > 100 && num < 1000)
            {
                bonus = (20.0 / 100.0) * num;
                if (num % 2 == 0)
                {
                    bonus += 1;
                }
                else if (num % 10 == 5)
                {
                    bonus += 2;
                }
                num += bonus;
            }
            else if(num >= 1000)
            {
                bonus = (10.0 / 100.0) * num;
                if(num % 2 == 0)
                {
                    bonus += 1;
                }
                else if(num % 10 == 5)
                {
                    bonus += 2;
                }
                num += bonus;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num);
        }
    }
}
