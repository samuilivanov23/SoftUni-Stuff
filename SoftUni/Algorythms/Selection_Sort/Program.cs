using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 95, 98, 103, 109, 48, 92, 25, 106, 160, };
            Console.WriteLine("Selection sort:");
            PrintList(SelectionSort(input));
            Console.WriteLine("Bubble sort:");
            PrintList(BubbleSort(input));
            Console.WriteLine("Insertion sort:");
            PrintList(InsertionSort(input));
            Console.WriteLine("Merge sort:");
            PrintList(MergeSort(input));
        }

        public static List<int> SelectionSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int min = i;
                for(int j = min + 1; j < list.Count; j++)
                {
                    if(list[min] < list[j])
                    {
                        min = j;        
                    }
                }
                int swap = list[i];
                list[i] = list[min];
                list[min] = swap;
            }
            return list;
        }

        public static List<int> BubbleSort(List<int> list)
        {
            bool swaped = false;
            swaped = false;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int swap = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = swap;
                        swaped = true;
                    }
                }
                if (!swaped)
                {
                    break;
                }
            }
            return list;
        }

        public static List<int> InsertionSort(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if(list[j - 1] > list[j])
                    {
                        int swap = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = swap;
                    }
                }
            }
            return list;
        }

        public static List<int> MergeSort(List<int> unsorted)
        {
            if(unsorted.Count <= 1)
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
             while(left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() <= right.First())
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
                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if(right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine(String.Join(", ", list));
        }

    }
}
