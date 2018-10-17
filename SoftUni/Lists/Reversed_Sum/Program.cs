using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            //int inv = 0;
            int[] new_nums = new int[nums.Count];
            for(int i = 0; i < nums.Count; i++)
            {
                while(nums[i] > 0)
                {
                    //inv = nums[0] % 10;
                    new_nums[i] *= 10;
                    new_nums[i] += nums[i] % 10;
                    nums[i] /= 10; 
                }
            }

            for(int i = 0; i < nums.Count; i++)
            {
                sum += new_nums[i];
            }

            Console.WriteLine(sum);
        }
    }
}
