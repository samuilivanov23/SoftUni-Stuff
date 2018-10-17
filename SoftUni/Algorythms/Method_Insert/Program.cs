using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            bool is_added = false;

            for (int i = 0; i < input.Count; i++)
            {
                if(number > input[i])
                {
                    result.Add(input[i]);
                }
                else if(!is_added)
                {
                    result.Add(number);
                    is_added = true;
                    i--;
                }
            }
        }
    }
}
