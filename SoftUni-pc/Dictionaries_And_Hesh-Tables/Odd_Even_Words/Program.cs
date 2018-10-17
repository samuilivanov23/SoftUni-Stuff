using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Even_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            //List<string> result = new List<string>();

            foreach(var word in counts)
            {
                if((word.Value) % 2 != 0)
                {
                    //result.Add(word.Key);
                    Console.Write($"{word.Key}, ");
                }
            }
            Console.WriteLine();


        }
    }
}
