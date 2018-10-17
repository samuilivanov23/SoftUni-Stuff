using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesInCM
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            string value = Console.ReadLine();
            DateTime result = DateTime.ParseExact(value, format, null);
            Console.WriteLine(result.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
