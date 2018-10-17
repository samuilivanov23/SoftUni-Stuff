using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ListOfCars : Box<Car>
    {
        private List<Car> cars;

        public ListOfCars()
        {
            Cars = new List<Car>();
        }

        public List<Car> Cars { get => cars; private set => cars = value; }

        public void Add(Car car)
        {
            Cars.Add(car);
        }
    }
}
