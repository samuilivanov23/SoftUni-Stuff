using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < input.Count; i++)
            {
                if(number == input[i])
                {
                    Console.WriteLine($"{number} Exists in the Array");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{number} doesn't exists in the Array");
            }
        }
    }
}
