using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<string> list = new DynamicList<string>("Pesho");
            list.Add("Sami");
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.RemoveAt("Pesho");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(list.Contains("Pesho"));
            Console.WriteLine(list.Contains("Sami"));
        }
    }
}
