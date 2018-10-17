using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 5, 4, 3, 0, 2, 2, 2 };

            Console.WriteLine(String.Join(", ", getMaxSUbsequence(list)));

        }

        public static List<int> getMaxSUbsequence(List<int> list)
        {
            var maxSubsequence = new List<int>();
            var tempSubsequence = new List<int>();
            tempSubsequence.Add(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                if(tempSubsequence.Last() - 1 == list[i])
                {
                    tempSubsequence.Add(list[i]);

                    if(tempSubsequence.Count > maxSubsequence.Count)
                    {
                        maxSubsequence.Clear();
                        maxSubsequence.AddRange(tempSubsequence);
                    }
                }
                else
                {
                    tempSubsequence.Clear();
                    tempSubsequence.Add(list[i]);
                }
            }
            return maxSubsequence;
        }
    }
}
