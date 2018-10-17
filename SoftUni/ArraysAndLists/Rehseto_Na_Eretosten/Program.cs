using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehseto_Na_Eretosten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            List<int> finalList = new List<int>();
            
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            for(int i = 0; i < 10; i++)
            {
                if(i < nums.Length)
                {
                    if(nums[i] == 2 || nums[i] == 3 || nums[i] == 5 || nums[i] == 7)
                    {
                        finalList.Add(nums[i]);
                    }
                }
            }

            for(int i = 11; i < nums.Length; i++)
            {
                if((nums[i] % 2 != 0) && (nums[i] % 3 != 0) && (nums[i] % 5 != 0) && (nums[i] % 7 != 0) && (nums[i] != 9))
                {
                    Console.WriteLine("index: " + i);
                    finalList.Add(nums[i]);
                }
            }

            foreach(int numbers in finalList)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
        }
    }
}
