using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Naklonena planina

            string[] a = { "+", "++", "+++", "++++", "+++++", "++++++", "+++++++", "++++++++", "+++++++++", "++++++++++" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            // Piramidka


            string[] b = { "          ", "         ", "        ", "       ", "      ", "     ", "    ", "   ", "  ", " " };
            string[] c = { "+", "+++", "+++++", "+++++++", "+++++++++", "+++++++++++", "+++++++++++++", "+++++++++++++++", "+++++++++++++++++", "+++++++++++++++++++" };
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine("{0}{1}", b[j], c[j]);
            }


            // kvadratche

            string[] d = { "++++++++++", "+        +" };
            for (int i = 0; i < 7; i++)
            {
                if (i == 0 || i == 6)
                {
                    Console.WriteLine(d[0]);
                }
                else Console.WriteLine(d[1]);
            }
        }
    }
}

