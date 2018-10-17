using System;
using System.Collections.Generic;
using System.Linq;
using StorageMaster.Products;
using StorageMaster.Vehicles;

namespace StorageMaster.Storages
{
    public abstract class Storage
    {
        private Vehicle[] garage;
        private List<Product> products;

        protected Storage(string name,
            int capacity,
            int garageSlots,
            IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.garage = new Vehicle[this.GarageSlots];
            this.products = new List<Product>();

            this.FillGarage(vehicles);
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => this.Products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            if (this.garage[garageSlot] == null) 
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            Vehicle vehicle = this.garage[garageSlot];
            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);
            int destinationGarageIndex = deliveryLocation.AddVehicle(vehicle);

            this.garage[garageSlot] = null;

            return destinationGarageIndex;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            int counter = 0;
            while (!this.IsFull && !vehicle.IsEmpty)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                counter++;
            }

            return counter;
        }

        private int AddVehicle(Vehicle vehicle)
        {
            int index = Array.IndexOf(this.garage, null);

            if (index == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[index] = vehicle;
            return index;
        }

        private void FillGarage(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }
    }
}