using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var flights = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            var list_input = input.Split(' ').ToList();
            var list_inputInt = new List<string>(list_input);
            list_inputInt.RemoveAt(0);


            while (input != "I believe i can fly!")
            {
                if(list_input[1] == "=")
                {
                    flights[list_input[0]] = flights[list_input[2]];
                }
                else if (!flights.ContainsKey(list_input[0]))
                {
                    flights[list_input[0]].AddRange(list_inputInt.Select(int.Parse));
                }
                else
                {
                    flights[list_input[0]].AddRange(list_inputInt.Select(int.Parse));
                }
                flights[list_input[0]] = flights[list_input[0]].OrderBy(x => x).ToList();
                input = Console.ReadLine();
                list_input = input.Split(' ').ToList();
                list_inputInt = new List<string>(list_input);
                list_inputInt.RemoveAt(0);
            }

            flights =  flights.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x=> x.Key , x=> x.Value);

            //smth
            foreach ()
            {


            }

        }
    }
}
