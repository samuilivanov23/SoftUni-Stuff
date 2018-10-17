using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string first_row1 = new string('\\', size);
            string first_row2 = new string('/', size);
            Console.Write(new string(' ', 2 * size));
            Console.Write(first_row1);
            Console.WriteLine(first_row2);
            //Console.Write(new string(' ', 2 * size));

            int size_tire = 6;
            int row_size = size * 6;

            for(int i = size-1; i >=1; i--)
            {
                Console.Write(new string(' ', i * 2));
                Console.Write(new string('\\', i));
                Console.Write(new string('-', size_tire));
                Console.Write(new string('/', i));
                //Console.Write(new string(' ', i * 2));
                Console.WriteLine();
                size_tire += 6;
            }

            if(size == 3)
            {
                Console.Write("|");
                Console.Write(new string('~', size - 1));
                Console.Write(new string('/', size));
                Console.Write(" ESTD ");
                Console.Write(new string('/', size));
                Console.Write(new string('~', size - 1));
                Console.WriteLine("|");
            }
            else
            {
                for(int i = 1; i <= (size - 2) / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('-' , size - 1));
                    Console.Write(new string('#' , size * 4));
                    Console.Write(new string('-', size - 1));
                    Console.WriteLine("|");
                }

                Console.Write("|");
                Console.Write(new string('~', size - 1));
                Console.Write(new string('/', (row_size - (2 + 2 + 4 + (2 * (size - 1)))) / 2));
                Console.Write(" ESTD ");
                Console.Write(new string('/', (row_size - (2 + 2 + 4 + (2 * (size - 1)))) / 2));
                Console.Write(new string('~', size - 1));
                Console.WriteLine("|");


                for (int i = 1; i <= (size - 2) / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('-', size - 1));
                    Console.Write(new string('#', size * 4));
                    Console.Write(new string('-', size - 1));
                    Console.WriteLine("|");
                }
            }

            /*for (int i = 1; i <= (size - 2) / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('-', size - 1));
                Console.Write(new string('#', size * 4));
                Console.Write(new string('-', size - 1));
                Console.WriteLine("|");
            }*/

            size_tire -= 6;
            for (int i = 1; i <= size - 1; i++)
            {
                Console.Write(new string(' ', i * 2));
                Console.Write(new string('\\', i));
                Console.Write(new string('-', size_tire));
                Console.Write(new string('/', i));
                //Console.Write(new string(' ', i * 2));
                Console.WriteLine();
                size_tire -= 6;
            }
            Console.Write(new string(' ', 2 * size));
            Console.Write(first_row1);
            Console.WriteLine(first_row2);
        }

        
    }
}
