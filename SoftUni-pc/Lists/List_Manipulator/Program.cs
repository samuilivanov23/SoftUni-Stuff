using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> comands = Console.ReadLine().Split(' ').ToList();

            while(comands[0] != "print")
            {
                switch (comands[0])
                {
                    case "add":
                        {
                            nums.Insert(int.Parse(comands[1]), int.Parse(comands[2]));
                            break;
                        }

                    case "addMany":
                        {
                            List<int> numbers = new List<int>();

                            for(int i = 2; i < comands.Count; i++)
                            {
                                numbers.Add(int.Parse(comands[i]));
                            }

                            numbers.Reverse();

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                nums.Insert(int.Parse(comands[1]), numbers[i]);
                            }
                            break;
                        }

                    case "contains":
                        {
                            if (nums.Contains(int.Parse(comands[1])))
                            {
                                Console.WriteLine(nums.IndexOf(int.Parse(comands[1])));
                            }
                            else
                            {
                                Console.WriteLine(-1);
                            }
                            break;
                        }

                    case "remove":
                        {
                            nums.RemoveAt(int.Parse(comands[1]));
                            break;
                        }

                    case "shift":
                        {
                            int temp = 0;

                            for(int i = 0; i < int.Parse(comands[1]); i++)
                            {
                                temp = nums[0];
                                for(int j = 0; j < nums.Count - 1; i++)
                                {
                                    nums[j] = nums[j + 1];
                                }

                                nums[nums.Count - 1] = temp;
                            }

                            break;
                        }

                    case "sumPairs":
                        {
                            List<int> sumList = new List<int>();

                            for (int i = 0; i < nums.Count - 1; i += 2)
                            {
                                sumList.Add(nums[i] + nums[i + 1]);
                            }

                            sumList.Reverse();
                            nums.Clear();

                            foreach (int numbers in sumList)
                            {
                                nums.Add(numbers);
                            }
                            break;
                        }
                }

                comands = Console.ReadLine().Split(' ').ToList();
            }

            foreach (int numbers in nums)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
        }
    }
}
