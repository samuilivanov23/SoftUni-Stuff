using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BireBure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            double currentVolume = 0;
            for (int i = 1; i <= 3*n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                currentVolume = Math.PI * Math.Pow(radius, 2) * height;
                if(currentVolume > volume)
                {
                    volume = currentVolume;
                }
            }
            Console.WriteLine(volume);
        }
    }
}
