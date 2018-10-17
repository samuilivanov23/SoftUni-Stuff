using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> input = new List<string>();

            while (true)
            {
                 input = Console.ReadLine().Split(' ').ToList();

                if(input[0] == "Delete")
                {
                    for(int i = 0; i < nums.Count; i++)
                    {
                        if(nums[i] == int.Parse(input[1]))
                        {
                            nums.Remove(nums[i]);
                            i--;
                        }
                    }
                }
                else if(input[0] == "Insert")
                {
                    nums.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if(input[0] == "Odd")
                {
                    for(int i = 0; i < nums.Count; i++)
                    {
                        if(nums[i] % 2 != 0)
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (input[0] == "Even")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
