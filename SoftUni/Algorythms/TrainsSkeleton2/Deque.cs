using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton2
{
    public class Deque<T> where T : Train
    {
        private static int defaultCapacity = 16;
        public int capacity; //показва капацитета
        private int count; //показва броят елементи

        public int Count { get { return count; } private set { count = value; } }
        public int Capacity { get { return capacity; } private set { capacity = value; } }

        public Deque() : this(defaultCapacity) { }
        Stack<T> passengersTrain;
        Stack<T> frightTrain;
        Stack<T> History;

        public Deque(int capacity)
        {
            passengersTrain = new Stack<T>(capacity);
            frightTrain = new Stack<T>(capacity);
            History = new Stack<T>(capacity);
            Capacity = capacity;
        }

        public Deque(IEnumerable<T> collection)
             : this(collection.Count())
        {
            foreach(var item in collection)
            {
                if(item is Train)
                {
                    if(item.Type == "P")
                    {
                        passengersTrain.Push(item);
                    }
                    else
                    {
                        frightTrain.Push(item);
                    }
                }
            }
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        }

        public void AddFront(T item)
        {
            passengersTrain.Push(item);
            Count++;
        }

        public void AddBack(T item)
        {
            frightTrain.Push(item);
            Count++;
        }

        public T RemoveFront()
        {
            if(passengersTrain.Count > 0)
            {
                Count--;
                History.Push(passengersTrain.Peek());
                return passengersTrain.Pop();
            }
            else
            {
                return null;
            }
        }

        public T RemoveBack()
        {
            if(frightTrain.Count > 0)
            {
                Count--;
                History.Push(frightTrain.Peek());
                return frightTrain.Pop();
            }
            else
            {
                return null;
            }
        }

        public T GetFront()
        {
            if (passengersTrain.Count > 0)
            {
                return passengersTrain.Peek();
            }
            return null;
            //връща, без да премахва, елемента отпред
        }

        public T GetBack()
        {
            if (frightTrain.Count > 0)
            {
                return frightTrain.Peek();
            }
            return null;
            //връща, без да премахва, елемента отзад
        }

        public T[] GetHistory()
        {
            return this.History.ToArray();
        }
    }
}
