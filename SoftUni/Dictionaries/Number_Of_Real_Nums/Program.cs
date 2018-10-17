using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Of_Real_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> kur = new SortedDictionary<double, int>();
            int times = 0;

            for(int i = 0; i < input.Count; i++)
            {
                //kur.Add(input[i], 0);
                for(int j = 0; j < input.Count; j++)
                {
                    if(input[j] == input[i])
                    {
                        times++;
                    }
                }
                if (!(kur.ContainsKey(input[i])))
                {
                    kur.Add(input[i], times);
                }
                times = 0;
            }

            foreach(var time in kur)
            {
                Console.WriteLine($"{time.Key} -> {time.Value}");
            }

        }
    }
}
