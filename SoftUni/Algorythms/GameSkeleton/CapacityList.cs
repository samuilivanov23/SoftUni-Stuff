using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSkeleton
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private int capacity;
        private Pair[] items;
        private int count;
        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
            this.Capacity = capacity;
            this.Count = 0;
        }

        public int Capacity { get { return capacity; } private set { capacity = value; } }
        public int Count { get { return count; } private set { count = value; } }

        public Pair SumIntervalPairs()
        {
            int first = 0;
            int last = 0;

            for(int i = startIndex; i < nextIndex; i++)
            {
                first += this.items[i].First;
                last += this.items[i].Last;
            }

            return new Pair(first, last);
        }

        public Pair Sum()
        {
            int first = 0;
            int last = 0;

            for (int i = 0; i < this.Count; i++)
            {
                first += this.items[i].First;
                last += this.items[i].Last;
            }

            return new Pair(first, last);
        }

        public void Add(Pair item)
        {
            if(this.Count < this.Capacity)
            {
                if(this.Capacity - this.Count > 1)
                {
                    if(nextIndex >= this.Capacity)
                    {
                        this.items[this.Count] = SumIntervalPairs();
                        this.Count++;
                        this.items[this.Count] = item;
                        startIndex = this.Count;
                        nextIndex = startIndex + 1;
                    }
                    else
                    {
                        this.items[nextIndex] = item;
                        nextIndex++;
                    }
                }
            }
        }

        public void PrintCurrentState()
        {
            for(int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}