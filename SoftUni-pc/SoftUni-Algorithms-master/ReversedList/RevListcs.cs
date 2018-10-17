using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    class RevListcs<T> : IEnumerable<T>
    {
        private const int INIT_CAPACITY = 2;
        private T[] items;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public RevListcs()
        {
            this.items = new T[INIT_CAPACITY];
            Capacity = INIT_CAPACITY;
        }

        public void Add(T element)
        {
            if (this.Count == this.Capacity)
            {
                Grow();
            }
            this.items[this.Count] = element;
            this.Count++;
        }

        private void Grow()
        {
            this.Capacity *= 2;
            T[] temp = new T[this.Capacity];
            for(int i = 0; i < this.Count; i++)
            {
                temp[i] = this.items[i];
            }
            items = temp;
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return this.items[index];
            }
            set
            {
                CheckIndex(index);
                this.items[index] = value;
            }
        }

        public T[] GetReversed()
        {
            return this.items.Take(this.Count).Reverse().ToArray();
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);
            T element = items[index];
            items = items.Take(index).Concat(items.Skip(index + 1)).ToArray();
            return element;
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("error");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
