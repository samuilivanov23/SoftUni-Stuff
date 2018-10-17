using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> finalList = new List<int>();
            int bomb = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());

            int index = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] == bomb)
                {
                    index = i - strength;
                    for(int j = 0; j < index; j++)
                    {
                        finalList.Add(nums[j]);
                    }

                    index += 2 * strength;

                    for (int j = index + 1; j < nums.Count; j++)
                    {
                        finalList.Add(nums[j]);
                    }
                }
                
            }

            int sum = 0;
            for (int i = 0; i < finalList.Count; i++)
            {
                Console.WriteLine(finalList[i]);
                sum += finalList[i];
            }

            Console.WriteLine("sum: " + sum);
        }
    }
}
