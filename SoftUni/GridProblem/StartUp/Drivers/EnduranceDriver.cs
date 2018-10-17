using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Drivers
{
    class EnduranceDriver : Driver
    {
        private const double ConstFuelConsumptionPerKm = 1.5;

        public EnduranceDriver(string name, Car car) 
            :base(name, car)
        {}
    }
}
