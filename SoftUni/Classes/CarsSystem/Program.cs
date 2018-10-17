using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            List<Car> cars = new List<Car>();
            Model model;
            Engine engine;
            Cargo cargo;
            List<Tire> tires = new List<Tire>(); ;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToList();
                model = new Model(input[0]);
                engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                cargo = new Cargo(int.Parse(input[3]), input[4]);
                tires.Add(new Tire(double.Parse(input[5]), int.Parse(input[6])));
                tires.Add(new Tire(double.Parse(input[7]), int.Parse(input[8])));
                tires.Add(new Tire(double.Parse(input[9]), int.Parse(input[10])));
                tires.Add(new Tire(double.Parse(input[11]), int.Parse(input[12])));
                cars.Add(new Car(model,engine, cargo, tires));
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    cars = cars.Where(x => x.cargo.type == "fragile").ToList();
                    for(int i = 0; i < cars.Count; i++)
                    {
                        cars[i].tires = cars[i].tires.Where(x => x.presure < 1).ToList();
                    }
                    foreach(Car car in cars)
                    {
                        Console.WriteLine($"{car.model.name}");
                    }
                    break;
                case "flamable":
                    cars = cars.Where(x => x.cargo.type == "flamable").ToList();
                    cars = cars.Where(x => x.engine.power > 250).ToList();
                    foreach (Car car in cars)
                    {
                        Console.WriteLine($"{car.model.name}");
                    }
                    break;
            }
        }
    }
}
