using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            int sum = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            var swap = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
            var max = arr[arr.Length - 1];
            for (int i = 0; i < n - 1; i++)
            {
                sum += arr[i];
            }
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.Write($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.Write($"Diff = {Math.Abs(max - sum)}");
            }
        }
    }
}
