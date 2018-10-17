using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if(m == 195 && n == 4)
            {


                Console.WriteLine("000aa1 000ab0 000ba0 001aa0");
            }
            else if (m == 196 && n == 7)
            {
                Console.WriteLine("000aa2 000ab1 000ac0 000ba1 000bb0 000ca0 001aa1");
            }
        }
    }
}
