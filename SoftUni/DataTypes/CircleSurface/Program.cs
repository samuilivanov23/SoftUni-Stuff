using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            double r= double.Parse(Console.ReadLine());
            double surface = Math.PI * r * r;
            Console.WriteLine($"{surface}");
        }
    }
}
