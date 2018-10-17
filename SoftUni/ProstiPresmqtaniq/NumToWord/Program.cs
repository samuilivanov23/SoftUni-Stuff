using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWord
{
    class Humarizen
    {
        static void Main()
        {
            string word;
            for (int i = 1; i <= 100; i++)
            {
                word = i.ToWords();
                Console.WriteLine(word);

            }
        }
    }
}
