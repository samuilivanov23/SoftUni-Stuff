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
        private int capacity;

        public int Count { get; set; }
        public int Capacity { get { return capacity; } private set { capacity = value; } }

        public Mlist()
        {
            this.items = new T[INITIAL_CAPACITY];
            this.Capacity = INITIAL_CAPACITY;
        }

        public Mlist(int capacity)
        {
            this.items = new T[capacity];
            this.Capacity = capacity;
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
            if(this.Count == this.Capacity)
            {
                this.Capacity += 1;
                T[] temp = new T[this.Capacity];
                for (int i = 0; i < this.items.Length; i++)
                {
                    temp[i] = this.items[i];
                }
                temp[this.items.Length] = element;
                this.items = temp;
                this.Count++;
            }
            else
            {
                items[Count] = element;
                this.Count++;
            }
        }

        public T[] GetArray()
        {
            return this.items.ToArray();
        }
    }
}
