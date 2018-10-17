using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var leftNums = new List<int>();
            var rightNums = new List<int>();
            var result = new List<int>();
            var sum = new List<int>(0);
            var centerList = new List<int>();

            int mainCount = nums.Count / 4;
            
            for(int i = mainCount; i <= nums.Count - 1 - mainCount; i++)
            {
                centerList.Add(nums[i]);
            }

            for (int i = mainCount - 1; i >= 0; i--)
            {
                leftNums.Add(nums[i]);
            }

            for (int i = nums.Count-1; i >= nums.Count - mainCount; i--)
            {
                rightNums.Add(nums[i]);
            }

            for (int i = 0; i < leftNums.Count; i++)
            {
                result.Add(leftNums[i]);
            }

            for (int i = 0; i < rightNums.Count; i++)
            {
                result.Add(rightNums[i]);
            }

            for(int i = 0; i < result.Count; i++)
            {
                sum.Add(result[i] + centerList[i]);
            }


            foreach (var num in sum)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            }
    }
}
