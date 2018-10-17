using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public class DistributionCenter : Storage
    {
        private const int capacity = 2;
        private const int garageslots = 5;
        private static Vehicle[] defaultvehicles = { new Van(), new Van(), new Van() };
        public DistributionCenter(string name)
        : base(name, capacity, garageslots, defaultvehicles)
        { }
    }
}
