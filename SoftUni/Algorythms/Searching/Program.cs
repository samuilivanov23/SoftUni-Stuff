using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 5, 2, 3, 6, 8, 10, 15};
            var sortedList = MergeSort(input);
            Console.WriteLine(BinarySearch(sortedList, 20, 0, sortedList.Count - 1));
        }

        public static bool BinarySearch(List<int> list, int key, int start, int end)
        {
            if (start > end)
            {
                return false;
            }
            else
            {
                int mid = (start + end) / 2;
                if (list[mid] > key)
                {
                    return BinarySearch(list, key, start, mid - 1);
                }
                else if (list[mid] < key)
                {
                    return BinarySearch(list, key, mid + 1, end);
                }
                else
                {
                    return true;
                }
            }
        }

        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);

        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
