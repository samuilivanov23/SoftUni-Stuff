using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int garageslots = 10;
        private static Vehicle[] defaultvehicles = { new Semi(), new Semi(), new Semi() };
        public Warehouse(string name)
        : base(name, capacity, garageslots, defaultvehicles)
        { }
    }
}
