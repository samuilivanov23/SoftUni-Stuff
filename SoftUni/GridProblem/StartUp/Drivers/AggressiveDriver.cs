using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Drivers
{
    class AggressiveDriver : Driver
    {
        private const double ConstFuelConsumptionPerKm = 2.7;

        public AggressiveDriver(string name, Car car) 
            :base(name, car)
        {
            //base.FuelConsumptionPerKm = ConstFuelConsumptionPerKm;
        }
    }
}
