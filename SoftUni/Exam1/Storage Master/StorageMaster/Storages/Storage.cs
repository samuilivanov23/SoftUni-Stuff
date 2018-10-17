using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Vehicles;
using StorageMaster.Products;
using System.Linq;

namespace StorageMaster.Storages
{
    public class Storage
    {
        public string Name { get; private set; }
        public int Capaticy { get; private set; }
        public int GarageSlots { get; private set; }

        private Vehicle[] garage;
        private List<Product> products;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Storage(string name, int capaticy, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capaticy = capaticy;
            GarageSlots = garageSlots;

            this.garage = new Vehicle[GarageSlots];
            this.products = new List<Product>();

            FillGatage(vehicles);
        }

        private void FillGatage(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;

            foreach (var vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= GarageSlots) throw new InvalidOperationException("Invalid garage slot!");
            if (this.garage[garageSlot] == null) throw new InvalidOperationException("No vehicle in this garage slot!");

            return this.garage[GarageSlots];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicleToBeSent = GetVehicle(garageSlot);
            bool hasEmptySlot = deliveryLocation.Garage
                                .Any(x => x == null);

            if (!hasEmptySlot) throw new InvalidOperationException("No room in garage!");

            deliveryLocation.AddVehicle(vehicleToBeSent);

            int deliveryLocationIndex = deliveryLocation.AddVehicle(vehicleToBeSent);
            this.garage[GarageSlots] = null;

            return deliveryLocationIndex;
        }

        private int AddVehicle(Vehicle vehicle)
        {
            int index = Array.IndexOf(this.garage, null);

            this.garage[index] = vehicle;
            return index;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.garage.Count() == GarageSlots) throw new InvalidOperationException("Storage is full!");
            Vehicle vehicle = GetVehicle(garageSlot);

            int index = 0;
            while (!(this.garage.Count() == GarageSlots) && !(this.garage.Count() == 0))
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                index++;
            }

            return index;
        }
    }
}
