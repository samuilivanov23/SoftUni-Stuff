using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            int[] num = new int[words.Count];
            string nums = "";
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 1; j < words[i].Length - 1; j++)
                {
                    nums += words[i][j];
                }
                num[i] = int.Parse(nums);
                nums = "";
            }

            int result = 0;
            int[] finalNums = new int[words.Count];
            for(int i = 0; i < words.Count; i++)
            {
                if(words[i][0] >= 'A' && words[i][0] <= 'Z')
                {
                    result = num[i] / ((words[i][0] - 'A') + 1);
                }
                else if (words[i][0] >= 'a' && words[i][0] <= 'z')
                {
                    result = num[i] * ((words[i][0] - 'a') + 1);
                }

                Console.WriteLine(result);

                if (words[i][words[i].Length - 1] >= 'A' && words[i][words[i].Length - 1] <= 'Z')
                {
                    result -= ((words[i][words[i].Length - 1] - 'A') + 1);
                }
                else if (words[i][words[i].Length - 1] >= 'a' && words[i][words[i].Length - 1] <= 'z')
                {
                    result += ((words[i][words[i].Length - 1] - 'a') + 1);
                }

                Console.WriteLine(result);

                finalNums[i] = result;
            }

            int sum = 0;
            for(int i = 0; i < finalNums.Length; i++)
            {
                sum += finalNums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
