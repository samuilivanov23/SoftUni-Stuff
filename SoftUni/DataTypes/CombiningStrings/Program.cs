using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombiningStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char spacer = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string str = " ";
            string final = " ";
            if (type == "even")
            {
                for (int i = 1; i <= n; i++)
                {
                    str = Console.ReadLine();
                    if(i % 2 == 0)
                    {
                        final += str + spacer;
                    }
                }
                final = final.Remove(final.Length - 1);
                Console.WriteLine(final);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    str = Console.ReadLine();
                    if (i % 2 != 0)
                    {
                        final += str + spacer;
                    }
                }
                final = final.Remove(final.Length - 1);
                Console.WriteLine(final);
            }
        }
    }
}
