using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPolindrom
{
    class Program
    {
        static bool IsPolindrom(string word)
        {
            int j = word.Length - 1;
            bool isPolindrom = true;
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] != word[j])
                {
                    isPolindrom = false;
                    break;
                }
                j--;
            }
            if (isPolindrom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool ispolindrom = IsPolindrom(word);
            Console.WriteLine(ispolindrom);
        }
    }
}
