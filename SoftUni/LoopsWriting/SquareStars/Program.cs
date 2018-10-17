using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var str = new string(' ', size);
            var stars = new string('*', size * 2);
            var line = new string('/', 2*size - 2);
            var line_ = new string('|', size);
            for (int row = 1; row <= size; row++)
            {
                if (row == 1 || row == size)
                {
                    Console.Write(stars);
                    Console.Write(str);
                    Console.Write(stars);
                }
                else
                {
                    if (row == (size - 1) / (2 - 1)-1)
                    {
                        Console.Write("*");
                        Console.Write(line);
                        Console.Write("*");
                        Console.Write(line_);
                        Console.Write("*");
                        Console.Write(line);
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(line);
                        Console.Write("*");
                        Console.Write(str);
                        Console.Write("*");
                        Console.Write(line);
                        Console.Write("*");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}