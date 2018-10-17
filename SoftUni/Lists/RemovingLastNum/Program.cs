using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingLastNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lastNum = nums[nums.Count - 1];

            for(int i = 0; i < nums.Count; i++)
            {
                if(nums[i] == lastNum)
                {
                    nums.RemoveAt(i);
                }
            }

            for(int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
