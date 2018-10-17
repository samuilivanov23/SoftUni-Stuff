using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int garageslots = 2;
        private static Vehicle[] defaultvehicles = { new Truck() };
        public AutomatedWarehouse(string name) 
            :base(name, capacity, garageslots, defaultvehicles)
        {}
    }
}
