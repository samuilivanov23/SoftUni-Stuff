using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Exam
{
    class Part
    {
        private string name;
        private double price;

        public Part(string name)
        {
            Name = name;
            this.price = 0;
        }

        public Part(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return "-> " + this.name + " - " + this.price.ToString(".00"); 
        }
    }
}
