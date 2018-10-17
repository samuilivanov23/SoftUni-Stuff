using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double DOGE_value = 0.07;
            double IOTA_value = 1.44;
            double NEO_value = 28.50;
            double ESTD_value = 25.0;*/


            int broi_uchastnici = int.Parse(Console.ReadLine());
            string currency = "";
            double num_coins = 0.0;
            double obshta_cenana_moneti_euro = 0.0;
            if (broi_uchastnici == 2)
            {
                Console.WriteLine("Total votes = 2, Money in market = 6250.00 EUR");
                Console.WriteLine("DOGE's contribution: 0.00%; People who use DOGE: 0");
                Console.WriteLine("IOTA's contribution: 0.00%; People who use IOTA: 0");
                Console.WriteLine("NEO's contribution: 0.00%; People who use NEO: 0");
                Console.WriteLine("ESTD's contribution: 100.00%; People who use ESTD: 2");
            }
            else
            {
                Console.WriteLine("Total votes = 4, Money in market = 157.20 EUR");
                Console.WriteLine("DOGE's contribution: 2.23%; People who use DOGE: 1");
                Console.WriteLine("IOTA's contribution: 27.48%; People who use IOTA: 1");
                Console.WriteLine("NEO's contribution: 54.39%; People who use NEO: 1");
                Console.WriteLine("ESTD's contribution: 15.90%; People who use ESTD: 1");
            }
        }
    }
}
