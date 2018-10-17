using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnAroundCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().Split(' ').Select(token => char.Parse(token)).ToArray();
            for(int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
