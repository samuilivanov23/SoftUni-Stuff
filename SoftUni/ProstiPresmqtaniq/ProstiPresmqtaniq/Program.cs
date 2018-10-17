using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiPresmqtaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] currency = {1, 1.79549, 1.95583, 2.53405};
            var money = double.Parse(Console.ReadLine());
            var sourceCurr = Console.ReadLine();
            var destCurr = Console.ReadLine();
            if(sourceCurr == "BGN" && destCurr == "USD")
            {
                Console.WriteLine("{0} {1}", Math.Round(money / 1.79549, 2), destCurr);
            }
            else if(sourceCurr == "BGN" && destCurr == "EUR")
            {
                Console.WriteLine("{0} {1}", Math.Round(money / 1.95583, 2), destCurr);
            }
            else if (sourceCurr == "BGN" && destCurr == "GBP")
            {
                Console.WriteLine("{0} {1}", Math.Round(money / 2.53405, 2), destCurr);
            }


            else if (sourceCurr == "USD" && destCurr == "BGN")
            {
                Console.WriteLine("{0} {1}", Math.Round(money * 1.79549, 2), destCurr);
            }
            else if (sourceCurr == "USD" && destCurr == "GBP")
            {
                Console.WriteLine("{0} {1}", Math.Round((money * 1.79549) / 2.53405, 2), destCurr);
            }
            else if (sourceCurr == "USD" && destCurr == "EUR")
            {
                Console.WriteLine("{0} {1}", Math.Round((money * 1.79549) / 1.95583, 2), destCurr);
            }


            else if (sourceCurr == "GBP" && destCurr == "EUR")
            {
                Console.WriteLine("{0} {1}", Math.Round((money * 2.53405) / 1.95583, 2), destCurr);
            }
            else if (sourceCurr == "GBP" && destCurr == "USD")
            {
                Console.WriteLine("{0} {1}", Math.Round((money * 2.53405) / 1.79549, 2), destCurr);
            }
            else if (sourceCurr == "GBP" && destCurr == "BGN")
            {
                Console.WriteLine("{0} {1}", Math.Round(money * 2.53405, 2), destCurr);
            }


            else if (sourceCurr == "EUR" && destCurr == "BGN")
            {
                Console.WriteLine("{0} {1}", Math.Round(money * 1.95583, 2), destCurr);
            }
            else if (sourceCurr == "EUR" && destCurr == "USD")
            {
                Console.WriteLine("{0} {1}", Math.Round((money * 1.95583) / 1.79549, 2), destCurr);
            }
            else if (sourceCurr == "EUR" && destCurr == "GBP")
            {
                Console.WriteLine("{0} {1}", Math.Round((money * 1.95583) / 2.53405, 2), destCurr);
            }
        }
    }
}
