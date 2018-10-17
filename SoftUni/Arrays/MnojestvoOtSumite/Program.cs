using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnojestvoOtSumite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            array[0] = 1;
            int j = 0;
            int temp = 0;
            int index = 1;
            int index_ = 0;
            for(int i = 1; i < array.Length; i++)
            {
                j = i;
                temp = 0;
                index_ = index;
                while(j > 0 && temp < k)
                {
                    array[index] += array[index_ - 1];
                    temp++;
                    j--;
                    index_--;
                }
                index++;
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
