using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[] ch = new char[n];
            string result = "";
            for(int i = 0; i < n; i++)
            {
                ch[i] = char.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                result += Convert.ToChar(ch[i] + key);
            }
            Console.WriteLine(result);
        }
    }
}
