using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle("Pesho", 2, 2, 0, 0);
            Rectangle rect2 = new Rectangle("Gosho", 2, 2, 5, 5);
            Console.WriteLine(rect1.OverLapping(rect2));
        }
    }
}
