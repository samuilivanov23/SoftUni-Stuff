using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> SquareNums = new List<int>();

            for(int i = 0; i < nums.Count; i++)
            {
                if(Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    SquareNums.Add(nums[i]);
                }
            }

            SquareNums.Sort();
            SquareNums.Reverse();

            foreach(int numbers in SquareNums)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
        }
    }
}
