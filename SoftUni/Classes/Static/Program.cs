using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = MyMath.Add(a, b);
            int d = MyMath.Multiply(a, b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            MyMath math = new MyMath();
            Console.WriteLine(MyMath.num);
        }
    }
}
