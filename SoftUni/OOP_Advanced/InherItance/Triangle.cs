using System;
using System.Collections.Generic;
using System.Text;

namespace InherItance
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, int size)
            :base(color, size)
        {}

        public override double GetArea()
        {
            double S = (Math.Pow(this.Size, 2) * Math.Sqrt(3)) / 4;
            return S;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
