using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token)).ToArray();
            for(int i = numbers.Length - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }

            }
            Console.WriteLine();
        }
    }
}
