using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, 6 };
            Console.WriteLine(Sum(arr, 0));
            Console.WriteLine(Factoriel(60));
            PrintFigure(5);
        }

        public static int Sum(int[] arr, int index)
        {
            if(index == arr.Length - 1)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, index + 1);
        }

        public static ulong Factoriel(ulong num)
        {
            if(num == 0 || num == 1)
            {
                return 1;
            }
            return num * Factoriel(num - 1);
        }

        public static void PrintFigure(int number)
        {
            if(number == 0)
            {
                return;
            }

            Console.WriteLine(new String('*', number));
            PrintFigure(number - 1);
            Console.WriteLine(new String('#', number));
        }
        
    }
}
