using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObmennoBiuro
{
    class Program
    {
        static void Main(string[] args)
        {
            string currency = Console.ReadLine();
            double euro_value = double.Parse(Console.ReadLine());

            if (currency == "ETH")
            {
                if ((euro_value / 250) >= 0.0099)
                {
                    if (euro_value > 1000)
                    {
                        euro_value += (10.0 / 100.0) * euro_value;
                    }

                    euro_value /= 250;

                    Console.Write("Successfully purchased ");
                    Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00}", euro_value));
                    Console.WriteLine(" ETH");

                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
            
            else if (currency == "XRP")
            {
                if((euro_value / 0.22) >= 80)
                {
                    if (euro_value > 1000)
                    {
                        euro_value += (10.0 / 100.0) * euro_value;
                    }

                    euro_value /= 0.22;
                    if (euro_value > 1000 && euro_value < 2500)
                    {
                        euro_value += euro_value * (5.0 / 100.0);
                    }
                    if (euro_value >= 2500)
                    {

                        euro_value += euro_value * (10.0 / 100.0);
                    }

                    Console.Write("Successfully purchased ");
                    Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00}", euro_value));
                    Console.WriteLine(" XRP");

                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
  
            }

            else if (currency == "BTC")
            {
                if ((euro_value / 6400) >= 0.001)
                {
                    if (euro_value > 1000)
                    {
                        euro_value += (10.0 / 100.0) * euro_value;
                    }

                    euro_value /= 6400;
                    if (euro_value > 10)
                    {
                        euro_value += euro_value * (2.0 / 100.0);
                    }

                    Console.Write("Successfully purchased ");
                    Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00}", euro_value));
                    Console.WriteLine(" BTC");

                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }

            else
            {
                Console.WriteLine($"EUR to {currency} is not supported.");
            }
        }
    }
}
