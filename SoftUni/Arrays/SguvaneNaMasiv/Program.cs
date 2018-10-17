using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SguvaneNaMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token)).ToArray();
            int center = numbers.Length / 2;
            int outside = (numbers.Length - center) / 2;
            int[] left_arr = new int[outside];
            int[] right_arr = new int[outside];
            int[] center_arr = new int[center];
            int[] sum = new int[outside * 2];
            int[] final_arr = new int[numbers.Length - center];

            for(int i = 0; i < outside; i++)
            {
                left_arr[i] = numbers[i];
            }

            for (int i = (center + outside); i < numbers.Length; i++)
            {
                right_arr[i - (outside + center)] = numbers[i];
            }

            for(int i = 0; i < outside; i++)
            {
                Console.WriteLine(i + outside);
                center_arr[i] = numbers[i + outside];
            }

            int temp = left_arr[left_arr.Length - 1];
            for (int i = 0; i < left_arr.Length; i++)
            {
                int curr = left_arr[i];
                left_arr[i] = temp;
                temp = curr;
            }

            temp = right_arr[right_arr.Length - 1];
            for (int i = 0; i < right_arr.Length; i++)
            {
                int curr = right_arr[i];
                right_arr[i] = temp;
                temp = curr;
            }

            for(int i = 0; i < sum.Length; i++)
            {
                if(i < (sum.Length / 2))
                {
                    sum[i] = left_arr[i];
                }
                else
                {
                    sum[i] = right_arr[i - outside];
                }
            }

            for(int i = 0; i < center_arr.Length; i++)
            {
                Console.WriteLine("center: " + center_arr[i]);
            }

            for(int i = 0; i < final_arr.Length; i++)
            {
                final_arr[i] = center_arr[i] + sum[i];
            }

            for (int i = 0; i < final_arr.Length; i++)
            {
                Console.WriteLine(final_arr[i]);
            }
        }
    }
}
