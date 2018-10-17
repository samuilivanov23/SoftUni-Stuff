using System;
using System.Collections.Generic;
using System.Linq;

namespace FirsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int token = int.Parse(Console.ReadLine());
            int SiteVisits = 0;
            double loses = 0.0;
            var sites = new List<string>();
            double sum = 0.0;
            List<string> input = new List<string>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();
                sites.Add(input[0]);
                SiteVisits = int.Parse(input[1]);
                loses = double.Parse(input[2]);
                sum += Convert.ToInt64(SiteVisits) * loses; 

            }

            foreach(var elem in sites)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine($"Total loss: {sum:f20}");
            Console.WriteLine("Security token: " + Math.Pow(token, n));
        }
    }
}
