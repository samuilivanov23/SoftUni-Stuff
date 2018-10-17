using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> name_price = new Dictionary<string, double>();
            Dictionary<Dictionary<string, double>, int> name_price_quantity = new Dictionary<Dictionary<string, double>, int>();
            List<string> inputs = new List<string>();

            while (true)
            {
                inputs = Console.ReadLine().Split(' ').ToList();
                if (!(name_price.ContainsKey(inputs[0])))
                {
                    name_price.Add(inputs[0], double.Parse(inputs[1]));
                    name_price_quantity.Add(name_price, 100);
                }
                else
                { 
                    name_price_quantity[name_price] += int.Parse(inputs[3]);
                    if (name_price[inputs[0]] != double.Parse(inputs[1]))
                    {
                        name_price[inputs[0]] = double.Parse(inputs[1]);
                    }
                }

                if(inputs[0] == "stocked")
                {
                    break;
                }
            }

            foreach(var product in name_price_quantity)
            {
                Console.WriteLine($"{product}");
            }

        }
    }
}
