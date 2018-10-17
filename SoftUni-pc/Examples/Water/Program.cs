using System;

namespace Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum_of_litres = 0;
            int times = 0;
            for(int i = 0; i < num; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters + sum_of_litres > 255)
                {
                    times++;
                }
                else
                {
                    sum_of_litres += liters;
                }
            }
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(sum_of_litres);
        }
    }
}
