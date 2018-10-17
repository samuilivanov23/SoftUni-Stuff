using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hour_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "22:45";

            var timeFromInput = DateTime.ParseExact(input, "H:m", null, DateTimeStyles.None);

            string timeIn24HourFormatForDisplay = timeFromInput.ToString("HH:mm",CultureInfo.InvariantCulture);

            
            Console.WriteLine(timeIn24HourFormatForDisplay);

            var list = new List<List<int>>();
            list.Add;
        }
    }
}
