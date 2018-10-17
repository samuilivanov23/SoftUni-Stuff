using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatSign = char.Parse(Console.ReadLine());
            char secondBoatSign = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string input = "";
            int firstBoatPos = 0;
            int secondBoatPos = 0;
            for(int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();
                if(input == "UPGRADE")
                {
                    firstBoatSign = Convert.ToChar(firstBoatSign + 3);
                    secondBoatSign = Convert.ToChar(secondBoatSign + 3);
                }
                else
                {
                    if(i % 2 != 0)
                    {
                        firstBoatPos += input.Length;
                    }
                    else
                    {
                        secondBoatPos += input.Length;
                    }
                }
                if(firstBoatPos >= 50)
                {
                    Console.WriteLine("First boat wins");
                    break;
                }
                else if (secondBoatPos >= 50)
                {
                    Console.WriteLine("Second boat wins");
                    break;
                }
            }
            if(secondBoatPos > firstBoatPos)
            {
                Console.WriteLine("Second boat wins");
            }
            else
            {
                Console.WriteLine("First boat wins");
            }
        }
    }
}
