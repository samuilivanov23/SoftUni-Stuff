using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> requirements = new List<string>();
            int timesMached = 0;
            bool isFound = false;
            int leftTimes = 3;
            int hidingLength = 0;
            int hidingIndex = 0;

            while (true)
            {
                requirements = Console.ReadLine().Split(' ').ToList();

                for(int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == char.Parse(requirements[0]))
                    {

                        timesMached ++;
                    }
                    else
                    {
                        if(timesMached >= int.Parse(requirements[1]))
                        {
                            hidingLength = timesMached;
                            isFound = true;
                            Console.WriteLine("i: " + i);
                            hidingIndex = i - timesMached;
                            break;
                        }
                        else
                        {
                            isFound = false;
                        }
                        timesMached = 0;
                    }
                }

                if (isFound)
                {
                    Console.WriteLine($"Hideout found at index {hidingIndex} and it is with size {hidingLength} !");
                    break;
                }
                else
                {
                    leftTimes--;
                }

                if(leftTimes <= 0)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("There is not hidding place!");
            }
        }
    }
}
