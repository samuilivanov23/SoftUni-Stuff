using System;

namespace Tourist_Info
{
    class Program
    {
        private static object exposure;

        static void Main(string[] args)
        {
            string metric = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double result = 0;
            if(metric == "miles")
            {
                result = value * 1.6;
            }
            else if(metric == "inches")
            {
                result = value * 2.54;
            }
            else if(metric == "foot")
            {
                result = value * 30;
            }
            else if(metric == "yards")
            {
                result = value * 0.91;
            }
            else
            {
                result = value * 3.8;
            }
            Console.WriteLine(Math.Round(value, 2));
        }
    }
}
