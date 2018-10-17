using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRect
{
    class Program
    {
        static void Main(string[] args)
        {
            var freshFood = Console.ReadLine();
            Console.WriteLine(freshFood);
            switch (freshFood)
            {
                case "banana":
                    Console.WriteLine("fruit");
                    break;
                case "aple":
                    Console.WriteLine("fruit");
                    break;
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                case "cherry":
                    Console.WriteLine("fruit");
                    break;
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "toamto":
                    Console.WriteLine("vegetable");
                    break;
                case "cocumber":
                    Console.WriteLine("vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                default: Console.WriteLine("unknown"); break;             
            }
        }
    }
}
