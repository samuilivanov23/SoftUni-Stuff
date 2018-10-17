using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Freight> freights = new Dictionary<string, Freight>();
            Dictionary<string, Truck> trucks = new Dictionary<string, Truck>();

            Freight freight;
            Truck truck;

            List<string> input = new List<string>();
            input = Console.ReadLine().Split(';', '=').Where(x => x != "").ToArray().ToList();

            for (int i = 0; i < input.Count() - 1; i += 2)
            {
                if (!trucks.ContainsKey(input[i]))
                {
                    if (double.Parse(input[i + 1]) < 0)
                    {
                        Console.WriteLine("Weight cannot be negative");
                    }
                    else if (input[i] == null)
                    {
                        Console.WriteLine("Name cannot be empty");
                    }
                    else
                    {
                        truck = new Truck();
                        truck.Name = input[i];
                        truck.Load = double.Parse(input[i + 1]);
                        trucks.Add(input[i], truck);
                    }
                }
            }

            List<string> truckInput = new List<string>();
            truckInput = Console.ReadLine().Split(';', '=').Where(x => x != "").ToArray().ToList();
            for(int i = 0; i < truckInput.Count() - 1; i += 2)
            {
                if (!freights.ContainsKey(truckInput[i]))
                {
                    if (double.Parse(truckInput[i + 1]) < 0)
                    {
                        Console.WriteLine("Weight cannot be negative");
                    }
                    else if(truckInput[i] == null)
                    {
                        Console.WriteLine("Name cannot be empty");
                    }
                    else
                    {
                        freight = new Freight();
                        freight.Name = truckInput[i];
                        freight.Weight = double.Parse(truckInput[i + 1]);
                        freights.Add(truckInput[i], freight);
                    }
                }

            }
            List<string> finalInputs = new List<string>();
            do
            {
                finalInputs = Console.ReadLine().Split(' ').ToList();
                if (!(finalInputs[0] == "END"))
                {
                    if (trucks[finalInputs[0]].Load > freights[finalInputs[1]].Weight)
                    {
                        trucks[finalInputs[0]].Freights.Add(freights[finalInputs[1]]);
                        trucks[finalInputs[0]].Load -= freights[finalInputs[1]].Weight;
                        Console.WriteLine($"{trucks[finalInputs[0]].Name} loaded {freights[finalInputs[1]].Name}");
                    }
                }
            }
            while (finalInputs[0] != "END");

            foreach (var truck_ in trucks.Values)
            {
                if (truck_.Freights.Count() > 0)
                {
                    Console.WriteLine($"{truck_.Name} - " + String.Join(", ", truck_.Freights.Select(x => x.Name)));
                }
                else
                {
                    Console.WriteLine($"{truck_.Name} - Nothing Loaded");
                }
            }
        }
    }
}
