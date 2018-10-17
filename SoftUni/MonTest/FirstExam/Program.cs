using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double mone_invested = double.Parse(Console.ReadLine());
            double bitcoin_value = double.Parse(Console.ReadLine());
            int satoshi_za_bit = int.Parse(Console.ReadLine());


            double bitcoin_purchased = mone_invested / bitcoin_value;

            double taksa_za_bitcoin = bitcoin_purchased * (satoshi_za_bit * 1024) / 100000000;

            double obshto_zakupen_bitcoin = bitcoin_purchased - taksa_za_bitcoin;

            double money_programator = obshto_zakupen_bitcoin * (10.0 / 100.0);

            double value_dollars = taksa_za_bitcoin * bitcoin_value;

            double ostavash_bitcoin = obshto_zakupen_bitcoin - money_programator;

            Console.Write("Total bitcoin after expenses: ");
            Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00000}", ostavash_bitcoin));
            Console.WriteLine(" BTC");

            Console.Write("Tax payed: ");
            Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00}", value_dollars));
            Console.WriteLine(" USD");

            Console.Write("Programmer`s payment: ");
            Console.Write(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.00000}", money_programator));
            Console.WriteLine(" BTC");



            /*Console.WriteLine($"Total bitcoin after expenses: {ostavash_bitcoin} BTC");
            Console.WriteLine($"Tax payed: {value_dollars} USD");
            Console.WriteLine($"Programmer`s payment: {money_programator} BTC");*/
        }
    }
}
