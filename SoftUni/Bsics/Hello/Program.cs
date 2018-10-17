using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (i == 0 || i == size - 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else{
                    Console.Write("*");
                    for(int z = 0; z < size - 2; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
