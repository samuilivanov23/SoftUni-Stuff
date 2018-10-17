using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = new List<string>();

            do
            {
                command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "push")
                {
                    nums.Add(int.Parse(command[1]));

                }
                else if (command[0] == "pop")
                {
                    Console.WriteLine(nums[nums.Count - 1]);
                    nums.RemoveAt(nums.Count - 1);

                }
                else if (command[0] == "shift")
                {
                    int temp = nums[0];
                    nums[0] = nums[nums.Count - 1];
                    nums[nums.Count - 1] = temp;

                }
                else if (command[0] == "addMany")
                {
                    var newList = new List<int>();
                    int j = int.Parse(command[1]);
                    bool isAdded = false;
                    for(int i = 0; i < nums.Count; i++)
                    {
                        if (i == j && !isAdded)
                        {
                            isAdded = true;
                            int comandIndex = 2;
                            for (int y = comandIndex; y < command.Count; y++)
                            {
                                newList.Add(int.Parse(command[y]));
                            }
                            i--;
                        }
                        else
                        {
                            newList.Add(nums[i]);
                        }
                    }

                    nums = new List<int>(newList);

                }
                else if (command[0] == "remove")
                {
                    if (int.Parse(command[1]) <= nums.Count - 1 && int.Parse(command[1]) >= 0)
                    {
                        nums.RemoveAt(int.Parse(command[1]));

                    }

                }

            } while (command[0] != "print");

            nums.Reverse();
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
