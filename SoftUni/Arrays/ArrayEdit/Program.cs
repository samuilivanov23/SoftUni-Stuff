using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
            string command = "";
            for(int i = 0; i < n; i++)
            {
                command = Console.ReadLine();

                if(command == "Distinct")
                {
                    int founded = 0;
                    for(int j = 0; j < words.Length; j++)
                    {
                        for(int z = 0; z < words.Length; z++)
                        {
                            if(words[j] == words[z])
                            {
                                founded++;
                            }
                        }
                        if(founded > 0)
                        {

                        }
                    }
                }
                else if(command == "Reverse")
                {

                }
                else if(command == "Replace")
                {
                    int index = int.Parse(Console.ReadLine());
                    string replacingWord = Console.ReadLine();

                }
            }
        }
    }
}
