using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string finalString = "";
            for (int i = 0; i < word.Length; i++)
            {
                finalString += "\\u" + ((int)word[i]).ToString("X").PadLeft(4, '0');
            }

            for(int i = 0; i < finalString.Length; i++)
            {
                Console.Write(finalString[i]);
            }

            Console.WriteLine();
        }
    }
}
