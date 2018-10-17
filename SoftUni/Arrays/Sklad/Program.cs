using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] count = Console.ReadLine().Split(' ').Select(token => long.Parse(token)).ToArray();
            double[] price = Console.ReadLine().Split(' ').Select(token => double.Parse(token)).ToArray();

            string[] product = new string[2];
            int index = 0;
            uint wanted_quantity = 0;
            product = Console.ReadLine().Split(' ');
            while (product[0] != "done")
            {
                index = Array.IndexOf(products, product[0]);
                if ((index < count.Length - 1) && (Convert.ToInt32(product[1]) <= count[index]))
                {
                    wanted_quantity = Convert.ToUInt32(product[1]);
                    Console.WriteLine($"{product[0]} x {wanted_quantity} costs {price[index] * wanted_quantity}");
                    count[index] -= wanted_quantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
                product = Console.ReadLine().Split(' ');
            }
        }
    }
}
