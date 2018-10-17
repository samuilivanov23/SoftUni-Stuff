using System;
using System.Collections.Generic;
using System.Text;

namespace InherItance
{
    class Circle : ColoredFigure
    {
        public Circle(string color, int size)
           : base(color, size)
        { }

        public override double GetArea()
        {
            return Math.Pow(this.Size, 2) * Math.PI;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
