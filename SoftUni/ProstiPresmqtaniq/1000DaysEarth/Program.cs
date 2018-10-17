using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysEarth
{
    class Program
    {
        static bool IsLeapYear(float year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) return true;

                    else return false;
                }
                else return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            string day, month, year;
            day = string.Concat(date[0], date[1]);
            month = string.Concat(date[3], date[4]);
            year = string.Concat(string.Concat(date[6], date[7]), string.Concat(date[8], date[9]));

            var day1 = int.Parse(day);
            var month1 = int.Parse(month);
            var year1 = int.Parse(year);

             int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            /* if (IsLeapYear(year1)) days[1]++;
             int deadline = 0;
             int day_ = days[month1] - day1;
             day1 += day_;
             deadline += day_;
             if(day1 > days[month1])*/

            year1 += 2;
            if ((12 - 9) < month1) year1 += 1;
            if((12 - 9) == 3)
            {
                if (day1 > 5) year1 += 1;
            }
            
            switch (month1)
            {
                case 1:
                    if (day1 > days[month1-1] - 26) month1 += 1;
                    break;
                case 2:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 3:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 4:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 5:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 6:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 7:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 8:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 9:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 10:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 11:
                    if (day1 > days[month1 - 1] - 26) month1 += 1;
                    break;
                case 12:
                    if (day1 > days[month1 - 1] - 26) month1 = 1;
                    break;
            }
            if(month1 + 9 > 12)
            {
                month1 = 1 + (9 - (12 - month1));
            }
            else month1 += 9;

            if(day1 + 26 > days[month1])
            {
                day1 = 1 + (26 - (days[month1] - day1));
            }
            Console.WriteLine("{0}-{1}-{2}", day1, month1, year1);
        }
    }
}
