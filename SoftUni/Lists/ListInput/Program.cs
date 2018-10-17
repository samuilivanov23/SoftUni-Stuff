using System;
using System.Collections.Generic;

namespace ListInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for(int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}] = {list[i]}");
            }
        }
    }
}
