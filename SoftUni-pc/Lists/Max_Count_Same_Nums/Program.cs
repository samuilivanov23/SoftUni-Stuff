using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Count_Same_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int br = 0;
            int currentBr = 0;
            int frequentNumber = 0;
            for(int i = 0; i < nums.Count - 1; i++)
            {
                if(nums[i] == nums[i + 1])
                {
                    currentBr++;
                }
                else
                {
                    currentBr = 0;
                }

                if(currentBr > br)
                {
                    br = currentBr;
                    frequentNumber = nums[i];
                }
                
            }

            for(int i = 0; i < br + 1; i++)
            {
                Console.Write(frequentNumber + " ");
            }

            Console.WriteLine();
        }
    }
}
