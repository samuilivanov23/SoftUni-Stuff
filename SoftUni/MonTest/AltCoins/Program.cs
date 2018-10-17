using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_bitcoins = double.Parse(Console.ReadLine());
            double start_bitcoin_value = double.Parse(Console.ReadLine());
            double current_bitcoin_value = double.Parse(Console.ReadLine());
            double koloichestvo_etereum = double.Parse(Console.ReadLine());
            double kolichestvo_neo = double.Parse(Console.ReadLine());

            double profit_from_difference = Math.Abs((num_bitcoins * start_bitcoin_value)- (num_bitcoins * current_bitcoin_value));

            double value_one_etereum = current_bitcoin_value *  (7.5/100.0);

            double value_one_neo = value_one_etereum * (40.0 / 100.0);

            double obshta_investiciq = (koloichestvo_etereum * value_one_etereum) + (kolichestvo_neo * value_one_neo);

            if(profit_from_difference >= obshta_investiciq)
            {
                Console.Write($"Stefcho bought ");
                Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.0000}", koloichestvo_etereum));
                Console.Write(" Ethereum at a price of ");
                Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.0000}", value_one_etereum));

                Console.Write($"Stefcho bought ");
                Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.0000}", kolichestvo_neo));
                Console.Write(" Neo at a price of ");
                Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.0000}", value_one_neo));

                Console.Write($"Stefcho has ");
                Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00}", (profit_from_difference - obshta_investiciq)));
                Console.WriteLine(" profits left to spend.");
            }
            else
            {
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.Write($"He needs ");
                Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.0000}", (obshta_investiciq - profit_from_difference)));
                Console.WriteLine(" more in profits.");
            }
        }
    }
}
