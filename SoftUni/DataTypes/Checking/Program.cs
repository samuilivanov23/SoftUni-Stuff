using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            if (ch >= '1' && ch <= '9')
            {
                Console.WriteLine("digit");
            }
            else if (ch == 'A' || ch == 'a' || ch == 'I' || ch == 'i' || ch == 'O' || ch == 'o' || ch == 'U' || ch == 'u' || ch == 'Y' || ch == 'y' || ch == 'E' || ch == 'e' || ch == 'W' || ch
                 == 'w'){
                Console.WriteLine("vowel");
            }
            else{
                Console.WriteLine("other");
            }
        }
    }
}
