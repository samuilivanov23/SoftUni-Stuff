using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Vehicles
{
    public class Truck : Vehicle
    {
        private const int capacity = 2;
        public Truck()
            : base(capacity)
        {}
    }
}
