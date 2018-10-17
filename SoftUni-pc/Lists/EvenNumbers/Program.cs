using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
