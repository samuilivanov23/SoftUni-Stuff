using System;
using System.Collections.Generic;
using System.Text;

namespace InherItance
{
    public abstract class ColoredFigure
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public ColoredFigure(string color, int size)
        {
            this.Color = color;
            this.Size = size;
        }


        public void Show()
        {
            Console.WriteLine($"{this.Color} and {this.Size}");
        }

        public abstract string GetName();

        public abstract double GetArea();
    }
}
