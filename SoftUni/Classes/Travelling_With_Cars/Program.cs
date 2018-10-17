using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_With_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<string> input = new List<string>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').ToList();
                cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            input = new List<string>();

            do
            {
                input = Console.ReadLine().Split(' ').ToList();
                if (input[0] != "End")
                {
                    foreach (Car car in cars)
                    {
                        if (car.Model == input[1])
                        {
                            car.CanDrive(double.Parse(input[2]));
                        }
                    }
                }
            }
            while(input[0] != "End");

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Current_Fuel.ToString(".00")} {car.Distance_Traveled}");
            }
        }
    }
}
