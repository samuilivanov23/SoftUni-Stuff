using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var list = CreateList<int>(1, 10);

            list.Where<int>(n => n > 10);
            Console.WriteLine(String.Join(", ", list));*/

            Box<string> boxOfStrings = new Box<string>();
            int boxCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < boxCount; i++)
            {
                string input = Console.ReadLine();
                boxOfStrings.Add(input);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index1 = indexes[0];
            int index2 = indexes[1];
            boxOfStrings.Swap(index1, index2);
            Console.WriteLine(String.Join(", ", boxOfStrings.Data));
        }

        public static List<T> CreateList<T>(T item, int count)
        {
            List<T> list = new List<T>();
            for(int i = 0; i < count; i++)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
