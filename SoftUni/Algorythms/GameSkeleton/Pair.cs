using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSkeleton
{
    class Pair
    {

        public int First { get; set; }

        public int Last { get; set; }

        public bool CanBeSummed { get; set; }

        public Pair(int first, int last)
        {
            First = first;
            Last = last;
        }

        public override string ToString()
        {
            return "(" + this.First + ", " + this.Last + ")";
        }

        public int Difference()
        {
            return Math.Abs(this.First - this.Last);
        }

    }
}
