using System;
using System.Collections.Generic;
using System.Linq;

namespace Frogs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Lake lake = new Lake(numbers);

            foreach(var number in lake)
            {
                Console.WriteLine(number);
            }
        }
    }
}
