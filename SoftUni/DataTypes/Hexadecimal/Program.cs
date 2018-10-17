using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int hex_in_int = Convert.ToInt32(hex, 16);
            Console.WriteLine($"{hex_in_int}");
        }
    }
}
