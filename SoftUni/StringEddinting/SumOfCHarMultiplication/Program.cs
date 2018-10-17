using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfCHarMultiplication
{
    class Program
    {
        static int SumChars(string str1, string str2)
        {
            int sum = 0;
            if(str1.Length > str2.Length)
            {
                for(int i = 0; i < str2.Length; i++)
                {
                    sum += Convert.ToInt32(str1[i]) * Convert.ToInt32(str2[i]);
                }
            }
            else if(str1.Length < str2.Length)
            {
                for(int i = 0; i < str1.Length; i++)
                {
                    sum += Convert.ToInt32(str1[i]) * Convert.ToInt32(str2[i]);
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += Convert.ToInt32(str1[i]) * Convert.ToInt32(str2[i]);
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            List<string> words = Console.ReadLine().Split(' ').ToList();
            int sum = SumChars(words[0], words[1]);
            Console.WriteLine(sum);
        }
    }
}
