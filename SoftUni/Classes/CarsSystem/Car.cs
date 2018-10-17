using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem
{
    class Car
    {
        public Model model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;

        public Car(Model model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }
}
