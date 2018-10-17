using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfNames_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string word = "abc";
            string newWord = "";
            for(int i = 0; i < word.Length; i++)
            {
                newWord += word[i];
            }

            Console.WriteLine(newWord);*/
            
            List<string> names = Console.ReadLine().Split(", ").ToList();

            string[] reversed = new string[2];
            int index = 0;
            for(int i = 0; i < names[0].Length; i++)
            {
                if(names[0][i] == ' ')
                {
                    index = i;

                    for(int j = 0; j < index; j++)
                    {
                        reversed[0] += names[0][j];
                    }
                }
                break;
            }

            for(int i = index + 1; i < names[0].Length; i++)
            {
                reversed[1] += names[0][i];
            }

            Console.WriteLine("reversed[0]: " + reversed[0]);
            Console.WriteLine("reversed[1]: " + reversed[1]);

            string temp = reversed[0];
            Console.WriteLine("temp: " + temp);
            reversed[0] = reversed[1];
            reversed[1] = temp;

            Console.WriteLine(reversed[0]);
            Console.WriteLine(reversed[1]);
            
        }
    }
}
