using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Mlist<int> list = new Mlist<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            foreach (var item in list.GetArray())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Count);
        }
    }
}
