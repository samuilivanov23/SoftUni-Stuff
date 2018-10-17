using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyToNanoSec
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            double nanoSec = century * 100 * 365.24 * 24 * 60 * 60 * 1000 * 1000 * 1000;
            Console.WriteLine(nanoSec);
        }
    }
}
