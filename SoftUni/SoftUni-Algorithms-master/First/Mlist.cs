using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Mlist<T>
    {
        private const int INITIAL_CAPACITY = 2;
        private T[] items;

        public int Count { get; set; }

        public Mlist(int capacity = INITIAL_CAPACITY)
        {
            this.items = new T[capacity];
            capacity = 4;
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= items.Length)
                {
                    throw new ArgumentOutOfRangeException("Error");
                }
                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new ArgumentOutOfRangeException("Error");
                }
                this.items[index] = value;
            }
        }

        public void Add(T element)
        {
            if(this.Count == INITIAL_CAPACITY)
            {
                Capacity += 2;
                T[] temp = new T()
            }
            else
            {
                items[Count] = element;
            }
        }
    }
}
