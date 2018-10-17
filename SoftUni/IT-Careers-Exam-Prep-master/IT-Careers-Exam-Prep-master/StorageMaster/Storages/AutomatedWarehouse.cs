using System.Collections.Generic;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;
        private static Vehicle[] AutomatedWarehouseVehicles =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name) :
            base(name, AutomatedWarehouseCapacity,
                AutomatedWarehouseGarageSlots,
                AutomatedWarehouseVehicles)
        { }
    }
}