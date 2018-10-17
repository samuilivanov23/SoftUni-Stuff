using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// fully wrong!!!!!
/// </summary>
namespace Words
{
    class Program
    {

        static int count = 0;
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            char[] combinations = new char[letters.Length];
            GenerateWord(letters, combinations, 0, 0);
            Console.WriteLine(count);
        }

        private static void GenerateWord(string letters, char[] combinations, int index, int borders)
        {
            if (index >= combinations.Length - 1)
            {
                bool valid = true;
                for (int i = 0; i < combinations.Length - 1; i++)
                {
                    if(combinations[i] == combinations[i + 1])
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid) count++;
            }
            else
            {
                for (int i = borders + 1; i <= letters.Length; i++)
                {
                    combinations[index] = letters[i - 1];
                    GenerateWord(letters, combinations, index + 1, i);
                }
            }
        }
    }
}
