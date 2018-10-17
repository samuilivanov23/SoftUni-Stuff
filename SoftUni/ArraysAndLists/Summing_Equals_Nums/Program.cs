using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing_Equals_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int i = 0;
            while (i < nums.Count - 1)
            {

                if (nums[i] == nums[i + 1])
                {
                    sum = nums[i] + nums[i + 1];
                    nums[i] = sum;
                    nums.RemoveAt(i + 1);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            foreach(int numbers in nums)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
        }
    }
}
