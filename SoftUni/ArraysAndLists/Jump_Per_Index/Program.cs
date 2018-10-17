using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Per_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            sum += nums[0];
            if (nums[0] > nums.Length)
            {
                Console.WriteLine(sum);
            }
            else
            {
                int index = nums[0];
                while (true)
                {
                    sum += nums[index];
                    Console.WriteLine("sum: " + sum);
                    if((nums[index] + index) < nums.Length)
                    {
                        index += nums[index];
                        sum += nums[index]; 
                    }
                    else if(nums[index] - index >= 0)
                    {
                        index -= nums[index];
                        sum += nums[index];
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine("index: " + index);
                }
                Console.WriteLine(sum);
            }
        }
    }
}
