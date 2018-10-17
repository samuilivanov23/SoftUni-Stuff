using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChekNumType
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            if (num > long.MaxValue && num < long.MinValue)
            {
                Console.WriteLine("Cant fit in any type");
            }
            else
            {
                if(num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {

                    Console.WriteLine("Can fit in: ");
                    Console.WriteLine("*sbyte");
                    if(num > 0 && num < 127)
                    {
                        Console.WriteLine("*byte");
                        Console.WriteLine("*ushort");
                        Console.WriteLine("*uint");
                        Console.WriteLine("*ulong");
                    }
                    else if(num > 0)
                    {
                        Console.WriteLine("*ushort");
                        Console.WriteLine("*uint");
                        Console.WriteLine("*ulong");
                    }
                    Console.WriteLine("*short");
                    Console.WriteLine("*int");
                    Console.WriteLine("*long");
                }
                if(num >= short.MinValue && num <= short.MaxValue)
                {
                    Console.WriteLine("Can fit in: ");
                    Console.WriteLine("*short");
                    if(num > 0 && num < short.MaxValue)
                    {
                        Console.WriteLine("*ushort");
                        Console.WriteLine("*uint");
                        Console.WriteLine("*ulong");
                    }
                    else if(num > 0)
                    {
                        Console.WriteLine("*uint");
                        Console.WriteLine("*ulong");
                    }
                    Console.WriteLine("*int");
                    Console.WriteLine("*long");
                }
            }
        }
    }
}
