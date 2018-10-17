using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Box<T>
    {
        private List<T> data;

        public List<T> Data
        {
            get { return data; }
            private set { data = value; }
        }

        public Box()
        {
            Data = new List<T>();
            Count = 0;
        }

        public void Add(T element)
        {
            Data.Add(element);
            Count++;
        }

        public T Remove()
        {
            T tempElement = Data.Last();
            Data.Remove(tempElement);
            Count--;
            return tempElement;
        }

        public int Count { get; private set; }
    }
}
