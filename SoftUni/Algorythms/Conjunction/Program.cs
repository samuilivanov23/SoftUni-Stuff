using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(Union(list1, list2));
            Console.WriteLine(Intersect(list1, list2));
            Console.WriteLine(UnionWithAddRange(list1, list2));
            Console.WriteLine(IntersectWithAddRange(list1, list2));
        }

        public static List<int> Union(List<int> list1, List<int> list2)
        {
            List<int> ret = new List<int>();

            foreach (var el in list2)
            {
                if (!ret.Contains(el))
                {
                    ret.Add(el);
                }
            }

            ret.Sort();
            return ret;
        }

        public static List<int> Intersect(List<int> list1, List<int> list2)
        {
            List<int> intersect = new List<int>();

            foreach (var el in list1)
            {
                if (list2.Contains(el))
                {
                    intersect.Add(el);
                }
            }
            intersect.Sort();
            return intersect;
        }

        public static List<int> IntersectWithAddRange(List<int> list1, List<int> list2)
        {
            List<int> intersect = new List<int>();

            intersect.AddRange(list1);

            intersect = intersect.Where(x => list2.Contains(x)).ToList();

            intersect.Sort();
            return intersect;
        }

        public static List<int> UnionWithAddRange(List<int> list1, List<int> list2)
        {
            List<int> union = new List<int>();

            union.AddRange(list1);

            for (int i = union.Count - 1; i >= 0; i--)
            {
                if (list2.Contains(union[i]))
                {
                    union.RemoveAt(i);
                }
            }

            union.AddRange(list2);
            union.Sort();
            return union;
        }
    }
}
