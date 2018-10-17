using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Box<T>
    {

        private List<T> data;

        public List<T> Data { get => data; private set => data = value; }

        public Box()
        {
            Data = new List<T>();
        }

        public void Swap(int index1, int index2)
        {
            var temp = Data[index1];
            Data[index1] = Data[index2];
            Data[index2] = temp;
        }

        public void Add(T element)
        {
            Data.Add(element);
        }
    }
}
