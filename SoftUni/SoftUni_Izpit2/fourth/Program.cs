using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, List<string>>();
            var command = new List<string>();

            do
            {
                command = Console.ReadLine().Split(' ').ToList();
                if(command[0] == "Add")
                {
                    if (!database.ContainsKey(command[1]))
                    {
                        var cities = new List<string>();
                        cities.Add(command[2]);
                        database.Add(command[1], cities);
                    }
                    else
                    {
                        database[command[1]].Add(command[2]);
                    }
                }
                else if(command[0] == "Remove")
                {
                    bool isCityFounded = false;
                    foreach (var pair in database.Keys)
                    {
                        for (int i = 0; i <= database[pair].Count - 1; i++)
                        {
                            if (database[pair][i] == command[1])
                            {
                                database[pair].Remove(command[1]);
                                isCityFounded = true;
                                break;
                            }
                        }
                    }

                    if (!isCityFounded)
                    {
                        Console.WriteLine($"City {command[1]} not found");
                    }
                }

            } while (command[0] != "End");

            database = database.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            //database.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach(var pair in database.Keys)
            {
                Console.WriteLine($"{pair} has {database[pair].Count} cities and they are:{string.Join(", ", database[pair])}");
            }
        }
    }
}
