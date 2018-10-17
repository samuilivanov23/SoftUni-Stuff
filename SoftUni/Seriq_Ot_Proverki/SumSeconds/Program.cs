using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());
            var min = 0;
            var sec = 0;
            var sum = t1 + t2 + t3;
            
            if (sum < 60)
            {
                min = 0;
                sec = sum;
            }
            else if(sum == 60)
            {
                min = 1;
                sec = 0;
            }
            else if(sum > 60 && sum < 120)
            {
                min = 1;
                sec = sum - 60;
            }
            else if(sum == 120)
            {
                min = 2;
                sec = 0;
            }
            else if(sum > 120 && sum < 180)
            {
                min = 2;
                sec = sum - 120;
            }
            else if(sum == 180)
            {
                min = 3;
                sec = 0;
            }
            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
