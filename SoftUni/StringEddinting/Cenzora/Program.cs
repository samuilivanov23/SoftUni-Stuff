using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenzora
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            List<string> words = Console.ReadLine().Split(' ').ToList();
            List<string> finalList = new List<string>();

            for(int i = 0; i < words.Count; i++)
            {
                if(words[i] == key)
                {
                    finalList.Add(new string('*', key.Length));
                }
                else
                {
                    finalList.Add(words[i]);
                }
            }

            foreach(string word_ in finalList)
            {
                Console.Write(word_ + " ");
            }
            Console.WriteLine();
        }
    }
}
