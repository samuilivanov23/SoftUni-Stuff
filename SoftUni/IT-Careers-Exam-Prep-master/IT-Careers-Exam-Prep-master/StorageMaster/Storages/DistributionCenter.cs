using System.Collections.Generic;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public class DistributionCenter : Storage
    {
        private const int DistributionCenterCapacity = 2;
        private const int DistributionCenterGarageSlots = 5;
        private static Vehicle[] DistributionCenterVehicles =
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name)
            : base(name, DistributionCenterCapacity, DistributionCenterGarageSlots, DistributionCenterVehicles)
        {
        }
    }
}