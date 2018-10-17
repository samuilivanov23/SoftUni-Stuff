using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentMark
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minut = int.Parse(Console.ReadLine());
            if(minut < 45)
            {
                minut += 15;
            }
            else
            {
                if (hour == 23)
                {
                    hour = 0;
                    minut = (15 - (60 - minut));
                }
                else
                {
                    hour += 1;
                    minut = (15 - (60 - minut));
                }
            }
            if(minut < 10) Console.WriteLine("{0}:0{1}", hour, minut);
            else Console.WriteLine("{0}:{1}", hour, minut);
            
        }
    }
}
