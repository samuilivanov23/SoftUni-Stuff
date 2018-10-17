using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingAndSummingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token)).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] rotated = new int[numbers.Length];
            for(int i = 0; i < rotated.Length - 1; i++)
            {
                rotated[i] = 0;
            }
            for(int i = 0; i < k; i++)
            {
                int temp = numbers[numbers.Length - 1];
                for (int j = 0; j < numbers.Length; j++)
                {
                    int curr = numbers[j];
                    numbers[j] = temp;
                    temp = curr;
                }

                for(int y = 0; y < numbers.Length; y++)
                {
                    rotated[y] += numbers[y];
                }
                
            }
            for(int i = 0; i < rotated.Length; i++)
            {
                 Console.Write(rotated[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
