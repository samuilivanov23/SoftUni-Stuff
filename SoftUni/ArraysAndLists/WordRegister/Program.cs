using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] {' ', ',', ';', ':', '.', '!', '(', ')', '\\', '/', '[', ']', '}' }).ToList();
            List<string> LowerCaseWords = new List<string>();
            List<string> UpperCaseWords = new List<string>();
            List<string> MiddleWords = new List<string>();
            int loweCount = 0;
            int UpperCount = 0;

            for(int i = 0; i < words.Count; i++)
            {
                for(int j = 0; j < words[i].Length; j++)
                {
                    if(words[i][j] >= 'a' && words[i][j] <= 'z')
                    {
                        loweCount++;
                    }
                    else if(words[i][j] >= 'A' && words[i][j] <= 'Z')
                    {
                        UpperCount++;
                    }
                }

                if(loweCount == words[i].Length)
                {
                    LowerCaseWords.Add(words[i]);
                }
                else if(UpperCount == words[i].Length)
                {
                    UpperCaseWords.Add(words[i]);
                }
                else
                {
                    MiddleWords.Add(words[i]);
                }

                UpperCount = 0;
                loweCount = 0;
            }
            Console.WriteLine("Lower case words: ");

            foreach(string words_ in LowerCaseWords)
            {
                Console.Write(words_ + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Upper case words: ");
            foreach (string words_ in UpperCaseWords)
            {
                Console.Write(words_ + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Different case words: ");
            foreach (string words_ in MiddleWords)
            {
                Console.Write(words_ + ", ");
            }
            Console.WriteLine();
        }
    }
}
