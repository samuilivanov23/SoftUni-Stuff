using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();

            for(int i = names.Count - 1; i>= 0; i--)
            {
                Console.Write(names[i] + "; ");
            }

            Console.WriteLine();
        }
    }
}
