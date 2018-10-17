using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    public class Deque<T> where T : Train
    {
        private static int defaultcapacity = 16;
        private int capacity;
        private int count;

        public int Capacity { get { return capacity; } private set { capacity = value; } }
        public int Count { get { return count; } private set { count = value; } }

        Stack<T> passengersTrain;
        Stack<T> freightTrain;
        Stack<T> history;

        public Deque() : this(defaultcapacity) { }

        public Deque(int capacity)
        {
            passengersTrain = new Stack<T>(capacity);
            freightTrain = new Stack<T>(capacity);
            history = new Stack<T>(capacity);
            this.Capacity = capacity;
        }

        public Deque(IEnumerable<T> collection)
             : this(collection.Count())
        {
            foreach (var item in collection)
            {
                if (item is Train)
                {
                    Train tempTrain = (Train)Convert.ChangeType(item, typeof(Train));
                    if (tempTrain.Type == "P")
                    {
                        passengersTrain.Push(item);
                    }
                    else
                    {
                        freightTrain.Push(item);
                    }
                }
            }
        }


        public void AddFront(T item)
        {
            passengersTrain.Push(item);
            this.Count++;
        }

        public void AddBack(T item)
        {
            freightTrain.Push(item);
            this.Count++;
        }

        public T RemoveFront()
        {
            if (this.passengersTrain.Count > 0)
            {
                this.Count--;
                history.Push(passengersTrain.Peek());
                return passengersTrain.Pop();
            }
            return null;
        }

        public T RemoveBack()
        {
            if (this.freightTrain.Count > 0)
            {
                this.Count--;
                history.Push(freightTrain.Peek());
                return freightTrain.Pop();
            }
            return null;
        }

        public T GetFront()
        {
            if (this.passengersTrain.Count > 0)
            {
                return passengersTrain.Peek();
            }
            return null;
        }

        public T GetBack()
        {
            if (this.freightTrain.Count > 0)
            {
                return freightTrain.Peek();
            }
            return null;
        }

        public T[] GetHistory()
        {
            return this.history.ToArray();
        }

    }
}
