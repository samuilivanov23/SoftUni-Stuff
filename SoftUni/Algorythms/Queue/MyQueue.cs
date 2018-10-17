using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class MyQueue<T>
    {
        private T[] elements;
        private int startIndex = 0;
        private int endIndex = 0;
        private const int DefaultCapacity = 4;
        public int Count { get; private set; }

        public MyQueue()
        {
            elements = new T[16];
        }

        public MyQueue(int capacity = DefaultCapacity)
        {
            elements = new T[DefaultCapacity];
        }

        public void Enqueue(T element)
        {
            if(this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            Count++;
        }

        public void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            this.CopyAllElemntsTo(newElements);
            this.elements = newElements;//proeneno
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        public void CopyAllElemntsTo(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for(int i = 0; i < this.Count; i++)
            {
                resultArr[destinationIndex] = this.elements[destinationIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }

        public T Dequeue()
        {
            if(this.Count == 0)
            {
                throw new ArgumentException("error");
            }
            var result = this.elements[startIndex];
            startIndex = (startIndex + 1) % this.elements.Length;
            Count--;
            return result;
        }

        public T[] ToArray()
        {
            //return this.elements.ToArray();
            T[] array = new T[Count];
            this.CopyAllElemntsTo(array);
            return array;
        }

    }
}
