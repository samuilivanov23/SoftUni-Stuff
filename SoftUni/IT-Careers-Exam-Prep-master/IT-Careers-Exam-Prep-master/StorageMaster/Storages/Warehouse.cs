using System.Collections.Generic;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public class Warehouse : Storage
    {
        private const int WarehouseCapacity = 10;
        private const int WarehouseGarageSlots = 10;
        private static Vehicle[] WarehouseVehicles =
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name) 
            : base(name, WarehouseCapacity, WarehouseGarageSlots, WarehouseVehicles)
        {
        }
    }
}