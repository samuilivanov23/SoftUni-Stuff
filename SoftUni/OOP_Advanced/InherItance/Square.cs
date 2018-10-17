using System;
using System.Collections.Generic;
using System.Text;

namespace InherItance
{
    class Square : ColoredFigure
    {
        public Square(string color, int size)
            :base(color, size)
        {}

        public override double GetArea()
        {
            return Math.Pow(this.Size, 2);
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
