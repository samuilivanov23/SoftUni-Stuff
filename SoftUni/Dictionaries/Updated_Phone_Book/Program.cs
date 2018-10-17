using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updated_Phone_Book
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List<string> input = new List<string>();

            while (true)
            {
                input = Console.ReadLine().Split(' ').ToList();
                if(input[0] == "A")
                {
                    if (!phoneBook.ContainsKey(input[0]))
                    {
                        phoneBook.Add(input[1], input[2]);
                    }
                }
                else if(input[0] == "S")
                {
                    phoneBook.Remove(input[1]);
                }
                else if(input[0] == "ListALL")
                {
                    SortedDictionary<string, string> sorted = new SortedDictionary<string, string>();
                    foreach(var key in phoneBook)
                    {
                        sorted.Add(key.Key, key.Value);
                    }

                    foreach (var key in sorted)
                    {
                        Console.WriteLine($"{key.Key} -> {key.Value}");
                    }
                }
                else if(input[0] == "END")
                {
                    break;
                }
            }

        }
    }
}
