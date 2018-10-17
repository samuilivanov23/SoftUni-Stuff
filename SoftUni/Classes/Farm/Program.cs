using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Stamat", 20, 100);
            if (chicken.Age > 15 && chicken.Age < 0)
            {
                Console.WriteLine("chicken's name must be between 0 and 15");
            }
            else
            {
                Console.WriteLine(chicken.Age);
            }
        }
    }
}
