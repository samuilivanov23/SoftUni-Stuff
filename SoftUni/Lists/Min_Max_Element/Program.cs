using System;
using System.Collections.Generic;
using System.Linq;

namespace Min_Max_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int min = numbers[0];
            int max = numbers[0];

            for(int i = 1; i < numbers.Count; i++)
            {
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
                else if(max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            if (min == max)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == min)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == min)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == max)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
