using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuple
{
    class CustomList<T> where T : IComparable
    {
        private List<T> data;

        public List<T> Data
        {
            get { return data; }
            set { data = value; }
        }

        public CustomList()
        {
            Data = new List<T>();
        }


        public void Add(T element)
        {
            Data.Add(element);
        }

        public T Remove(int index)
        {
            var element = Data[index];
            Data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (element.Equals(Data[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            T temp = Data[index1];
            Data[index1] = Data[index2];
            Data[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return Data.Where(x => x.CompareTo(element) > 0).Count();
        }

        public T Max()
        {
            T element = Data[0];

            for (int i = 1; i < Data.Count; i++)
            {
                if(element.CompareTo(Data[i]) < 0)
                {
                    element = Data[i];
                }
            }

            return element;
        }

        public void Print()
        {
            foreach(var item in Data)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
