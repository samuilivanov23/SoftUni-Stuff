using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class MyQueue<T> : IEnumerable<T>
    {

        private class Node
        {
            public T Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }

            public Node(T value)
            {
                this.value = value;
            }
        }

        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            Node newNode = new DoubleLinkedList.MyQueue<T>.Node(element);
            if(Count == 0)
            {
                this.head = newNode;
            }
            else
            {
                newNode.PrevNode = this.tail;
                this.tail.NextNode = newNode;
            }
            this.tail = newNode;
            Count++;
        }

        public T Dequeue(T element)
        {
            if(Count == 0)
            {
                throw new ArgumentException("error");
            }

            T value = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.NextNode = null;
                Count--;
            }

            return value;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            Node currNode = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = currNode.Value;
                currNode = currNode.NextNode;
            }

            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currNode = this.head;

            while (currNode != null)
            {
                yield return currNode.Value;
                currNode = currNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
