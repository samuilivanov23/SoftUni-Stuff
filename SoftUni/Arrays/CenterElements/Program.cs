using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(token => int.Parse(token)).ToArray();
            for (int i = (nums.Length / 2) - 1; i < (nums.Length - ((nums.Length / 2) - 1)); i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
