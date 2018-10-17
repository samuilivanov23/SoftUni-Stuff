using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            List<Engine> helpEngine = new List<Engine>();
            int engineNum = int.Parse(Console.ReadLine());
            List<string> eng_input = new List<string>();
            List<string> car_input = new List<string>();

            for(int i = 0; i < engineNum; i++)
            {
                eng_input = Console.ReadLine().Split(' ').ToList();
                engines.Add(new Engine(eng_input[0], int.Parse(eng_input[1])));
            }

            int carNum = int.Parse(Console.ReadLine());

            for(int i = 0; i < carNum; i++)
            {
                car_input = Console.ReadLine().Split(' ').ToList();
                helpEngine = engines.Where(x => x.model == car_input[1]).ToList();
                cars.Add(new Car(car_input[0], helpEngine[0]));
            }

            for(int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].model + ":");
                Console.Write("   ");
                Console.WriteLine(cars[i].engine.model + ":");
                Console.Write("      ");
                Console.WriteLine("Power: " + cars[i].engine.power);

            }

        }
    }
}
