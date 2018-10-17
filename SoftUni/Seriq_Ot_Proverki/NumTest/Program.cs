using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumTest
{
    class Program
    {
        static float rectangleArea(float a, float b)
        {
            return a * b;
        }
        static float squareArea(float a)
        {
            return a * a;
        }
        static double circleArea(float radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static float triangleArea(float a, float h)
        {
            return (a * h) / 2;
        }
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            if(shape == "square")
            {
                var a = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(squareArea(a), 3)); 
            }
            else if(shape == "rectangle")
            {
                var a = float.Parse(Console.ReadLine());
                var b = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(rectangleArea(a, b), 3));
            }
            else if(shape == "circle")
            {
                var radius = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(circleArea(radius), 3));
            }
            else if(shape == "triangle")
            {
                var a = float.Parse(Console.ReadLine());
                var h = float.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(triangleArea(a, h), 3));
            }
        }
    }
}
