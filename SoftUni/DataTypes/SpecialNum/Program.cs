using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num_sum = 0; ;

            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                while(num > 0)
                {
                    int inv = num % 10;
                    num_sum += inv;
                    num /= 10;
                }
                if(num_sum == 5 || num_sum == 7 || num_sum == 11)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                num_sum = 0;
            }
        }
    }
}
