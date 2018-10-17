using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class DynamicList<T>
    {
        private Node head;
        private Node tail;
        private int count;

        public DynamicList(object element)
        {
            this.head = new Node(element);
            this.tail = head;
            this.count++;
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public void Add(T element)
        {
            Node newElement = new Node(element, this.tail);
            this.tail = newElement;
            Count++;
        }

        public object Remove(int index)
        {
            int currentIndex = 0;
            Node currentNode = this.head;
            Node prevNode = null;

            while(currentNode != null)
            {
                if(currentIndex == index)
                {
                    if(prevNode != null)
                    {
                        prevNode.Next = currentNode.Next;
                    }
                    else
                    {
                        this.head = currentNode.Next;
                    }

                    if(currentNode.Next == null)
                    {
                        this.tail = prevNode;
                    }
                    Count--;
                    return currentNode.Eement;
                }
                else
                {
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }

            return null;
        }

        public bool RemoveAt(object element)
        {
            int index = IndexOf(element);
            element = this.Remove(index);
            return element != null;
        }

        public int IndexOf(object element)
        {
            int currindex = 0;
            Node currNode = head;
            Node prevNode = tail;

            while (currNode != null)
            {
                if(currNode.Eement == element)
                {
                    return currindex;
                }
                currindex++;
                prevNode = currNode;
                currNode = currNode.Next;
            }
            return -1;
        }

        public bool Contains(object element)
        {
            return IndexOf(element) > -1;
        }

        public object this[int index]
        {
            get
            {
                int currindex = 0;
                Node currNode = this.head;
                while(currNode != null)
                {
                    if(currindex == index)
                    {
                        return currNode.Eement;
                    }
                    else
                    {
                        currNode = currNode.Next;
                        currindex++;
                    }
                }
                throw new ArgumentOutOfRangeException("Error");
            }

            set
            {
                int currindex = 0;
                Node currNode = this.head;
                while (currNode != null)
                {
                    if (currindex == index)
                    {
                        currNode.Eement = value;
                    }
                    else
                    {
                        currNode = currNode.Next;
                        currindex++;
                    }
                }
                throw new ArgumentOutOfRangeException("Error");
            }
        }
    }
}
