using System;
using System.Collections.Generic;
using System.Text;

namespace Vechicles
{
    interface IDrivable
    {
        double FuelPerKilometre { get; }
        double FuelAmount { get; }
        double Capacity { get; }

        void Drive(double distance);
        void ReFuel(double amount);
    }
}
