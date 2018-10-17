using System;
using System.Collections.Generic;
using System.Linq;

namespace LIS_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];
            List<int> finalList = new List<int>();

            int maxLen = 0;

            for(int i = 0; i < nums.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                maxLen = 0;
                for(int j = 0; j < i; j++)
                {
                    if((nums[j] < nums[i]) && len[j] > maxLen)
                    {
                        len[i]++;
                        prev[i] = j;
                        maxLen = len[j];
                    }
                }
            }

            int max = len[0];
            for(int i = 1; i < len.Length; i++)
            {
                if(max < len[i])
                {
                    max = len[i];
                }
            }

            int maxIndex = Array.IndexOf(len, max);

            for (int i = maxIndex; i > -1 ; i = prev[i])
            {
                finalList.Add(nums[i]);
            }

            finalList.Reverse();

            foreach(int numbers in finalList)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
        }
    }
}
