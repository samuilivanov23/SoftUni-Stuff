using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            RevListcs<string> list = new RevListcs<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            Console.WriteLine(list.Capacity);
            Console.WriteLine(String.Join(",", list));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
