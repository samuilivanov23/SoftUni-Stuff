using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[] {10, 20, 30, 40};
            int[] vector = new int[k];
            GenerateCombinations(arr, vector, 0, 0);
        }

        private static void GenerateCombinations(int[] set, int[] vector, int index, int border)
        {
            if(index >= vector.Length)
            {
                PrintVector(vector);
            }
            else
            {
                for (int i = border + 1; i <= set.Length; i++)
                {
                    vector[index] = set[i - 1];
                    GenerateCombinations(set, vector, index + 1, i);
                }
            }
        }

        private static void PrintVector(int[] vector)
        {
            Console.WriteLine(String.Join(", ", vector));
        }
    }
}
