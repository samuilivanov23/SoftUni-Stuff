using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSeller
{
    class Engine
    {
        public string model;
        public int power;

        public Engine()
        {

        }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }
    }
}
