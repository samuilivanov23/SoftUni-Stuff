using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_people = int.Parse(Console.ReadLine());
            int capacitet = int.Parse(Console.ReadLine());
            int num_courses = 0;
            if(num_people % capacitet != 0)
            {
                num_courses = (num_people / capacitet);
                Console.WriteLine(num_courses + 1);
            }
            else if(num_people < capacitet)
            {
                Console.WriteLine(1);
            }
            else
            {
                num_courses = num_people / capacitet;
                Console.WriteLine(num_courses);
            }

            
        }
    }
}
