using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSeller
{
    class Car
    {
        public string model;
        public Engine engine;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }
    }
}
