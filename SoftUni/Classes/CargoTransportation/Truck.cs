using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTransportation
{
    class Truck
    {
        private string name;
        private double load;
        private List<Freight> freights;
        
        public Truck()
        {
            freights = new List<Freight>();
        }

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

        public double Load
        {
            get { return load; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can't be less than 0");
                }
                else
                {
                    load = value;
                }
            }
        }

        public List<Freight> Freights
        {
            get { return freights; }
            private set { freights = value; }
        }
    }
}
