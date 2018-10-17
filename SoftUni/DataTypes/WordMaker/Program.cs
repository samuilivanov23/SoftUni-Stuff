using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = " ";
            for(int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                word += ch;
            }
            Console.WriteLine(word);
        }
    }
}
