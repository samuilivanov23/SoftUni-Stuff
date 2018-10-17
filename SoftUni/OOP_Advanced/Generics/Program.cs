using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ListOfCars cars = new ListOfCars();
            Car car = new Car();

            cars.Add(car);

            Console.WriteLine(String.Join(", ", cars.Data));*/


            /*Box<int> box = new Box<int>();

            box.Add(2);
            box.Add(3);
            box.Add(4);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

            Console.WriteLine(String.Join(", ", box.Data));*/



            Box<int> boxOfInts = new Box<int>();
            int count = int.Parse(Console.ReadLine());
            int element;

            for(int i = 0; i < count; i++)
            {
                element = int.Parse(Console.ReadLine());
                boxOfInts.Add(element);
            }

            foreach (var num in boxOfInts.Data)
            {
                Console.WriteLine($"{num.GetType().FullName}: {num}");
            }
        }
    }
}
