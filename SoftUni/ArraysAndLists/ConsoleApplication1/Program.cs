using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());
            int index = 0;
            int sum = 0;
            bool is_found = false;

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if(n == nums[i])
                {
                    index = i;
                    break;
                }
                else
                {
                    is_found = true;
                }

            }
            if (!is_found)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += nums[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
