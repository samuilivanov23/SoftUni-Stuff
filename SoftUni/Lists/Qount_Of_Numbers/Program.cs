using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qount_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> finalList = new List<int>();
            nums.Sort();
            int count = 0;

            for(int i = 0; i < nums.Count; i++)
            {
                for(int j = 0; j < nums.Count; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                finalList.Add(count);
                count = 0;
            }
            
            for(int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " -> " + finalList[i]);
                Console.WriteLine();
            }
        }
    }
}
