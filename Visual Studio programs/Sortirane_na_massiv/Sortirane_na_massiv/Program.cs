using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sortirane_na_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] a = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            int max = 0;
           
             for (int j = 0; j < a.Length; j++)
             {
                 for (int i = 0; i < a.Length-1; i++)
                 {
                     if (a[i] > a[i + 1])
                     {
                        max = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = max;
                     }
                 }
                
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ", ");
            }
            




        }
    }
}

