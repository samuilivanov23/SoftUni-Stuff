using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double mins = double.Parse(Console.ReadLine());
            double secs = double.Parse(Console.ReadLine());
            double time = secs + (mins * 60) + (hours * 3600);

            double m_speed = meters / time;
            double kilos = meters / 1000;
            double k_speed = kilos / hours;
            double mil = meters / 1609;
            double mi_speed = mil / hours;
            Console.WriteLine(Math.Round(m_speed, 6));
            Console.WriteLine(Math.Round(k_speed, 6));
            Console.WriteLine(Math.Round(mi_speed, 6));
        }
    }
}
