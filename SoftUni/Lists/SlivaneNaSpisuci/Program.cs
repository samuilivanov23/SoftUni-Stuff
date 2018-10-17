using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivaneNaSpisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            List<string> new_list = new List<string>();
            int index = 0;
            for(int i = 0; i < lists.Count; i++)
            {
                for(int j = 0; j < lists[i].Length; j++)
                {
                    if(lists[i][j] != ' ')
                    {
                        new_list.Add(Convert.ToString(lists[i][j]));
                        new_list.Add(" "); 
                    }
                }
            }
            for(int i = new_list.Count; i >= 0; i--)
            {
                Console.Write(new_list[i]);
            }

            Console.WriteLine();
            
        }
    }
}
