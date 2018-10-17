using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int density = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            double coef;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                coef = input[0] / input[1];
                sum += coef;
            }

            if (density == 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                double result = sum / density;
                Console.WriteLine($"{result.ToString()}");
            }
        }
    }
}
