using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vectors = new int[n];
            GenerateVector(vectors, 0);
        }

        private static void GenerateVector(int[] vectors, int n)
        {
            if(n >= vectors.Length)
            {
                PrintVector(vectors);
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vectors[n] = i;
                    GenerateVector(vectors, n + 1);
                }
            }
        }

        private static void PrintVector(int[] vectors)
        {
            Console.WriteLine(String.Join(String.Empty, vectors));
        }
    }
}