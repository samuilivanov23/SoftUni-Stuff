using System;
using System.Collections.Generic;

namespace Mine_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            string temp = "";
            do {
                temp = Console.ReadLine();
                input.Add(temp);
            }
            while(temp != "stop");

            Dictionary<string, int> mines = new Dictionary<string, int>();

            for(int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    if (!mines.ContainsKey(input[i - 1]))
                    {
                        mines.Add(input[i - 1], int.Parse(input[i]));
                    }
                    else
                    {
                        mines[input[i - 1]] += int.Parse(input[i]);
                    }
                }
            }

            foreach(var word in mines)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}
