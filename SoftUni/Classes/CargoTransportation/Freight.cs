using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportation
{
    class Freight
    {
        private string name;
        private double weight;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Can't be empty");
                }
                else
                {
                    name = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be less than 0");
                }
                else
                {
                    weight = value;
                }
            }
        }
    }
}
