using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StorageMaster.Products;
using StorageMaster.Storages;
using StorageMaster.Vehicles;

namespace StorageMaster
{
    public class StorageMaster
    {
        private Dictionary<string, Stack<Product>> products;
        private Dictionary<string, Storage> storages;
        private Vehicle currentVehicle;

        public StorageMaster()
        {
            this.products = new Dictionary<string, Stack<Product>>();
            this.storages = new Dictionary<string, Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = CreateProduct(type, price);

            if (this.products.ContainsKey(type) == false)
            {
                this.products.Add(type, new Stack<Product>());
            }

            this.products[type].Push(product);

            string result = $"Added {type} to pool";
            return result;
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = this.CreateStorage(type, name);
            this.storages.Add(name, storage);

            string result = $"Registered {name}";
            return result;
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);
            this.currentVehicle = vehicle;

            string result = $"Selected {this.currentVehicle.GetType().Name}";
            return result;
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int counter = 0;
            foreach (string productName in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }

                if (this.products.ContainsKey(productName) && this.products[productName].Count > 0)
                {
                    Product product = this.products[productName].Pop();
                    this.currentVehicle.LoadProduct(product);
                    counter++;
                }
                else
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }
            }

            string result = $"Loaded {counter}/{productNames.Count()} products into {this.currentVehicle.GetType().Name}";
            return result;
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (this.storages.ContainsKey(sourceName) == false)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            if (this.storages.ContainsKey(destinationName) == false)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage sourceStorage = this.storages[sourceName];
            Storage destination = this.storages[destinationName];
            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destination);

            string result = $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
            return result;
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);

            int trunkCount = vehicle.Trunk.Count;
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            string result = $"Unloaded {unloadedProductsCount}/{trunkCount} products at {storageName}";
            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];

            Dictionary<string, int> productAndCounts = new Dictionary<string, int>();

            foreach (Product product in storage.Products)
            {
                string type = product.GetType().Name;

                if (productAndCounts.ContainsKey(type) == false)
                {
                    productAndCounts.Add(type, 0);
                }

                productAndCounts[type]++;
            }

            string[] productsInfo = productAndCounts
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key)
                .Select(kvp => $"{kvp.Key} ({kvp.Value})")
                .ToArray();

            double producstWeightSum = storage.Products.Sum(p => p.Weight);
            string stockLine =
                $"Stock ({producstWeightSum}/{storage.Capacity}): [{string.Join(", ", productsInfo)}]";

            string[] garageNames = storage.Garage
                .Select(g => g == null ? "empty" : g.GetType().Name)
                .ToArray();

            string garageLine = $"Garage: [{string.Join("|", garageNames)}]";

            string result = stockLine +
                            Environment.NewLine +
                            garageLine;
            return result;
        }

        public string GetSummary()
        {
            var sortedStorages = this.storages
                      .OrderByDescending(s => s.Value.Products.Sum(p => p.Price))
                      .ToDictionary(x => x.Key, x => x.Value);

            StringBuilder sb = new StringBuilder();
            foreach (var storage in sortedStorages)
            {
                double totalMoney = storage.Value.Products.Sum(p => p.Price);
                sb.AppendLine($"{storage.Key}:");
                sb.AppendLine($"Storage worth: ${totalMoney:F2}");
            }

            string result = sb.ToString().Trim();
            return result;
        }

        private Product CreateProduct(string type, double price)
        {
            Product product = null;

            switch (type)
            {
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }

            return product;
        }

        private Storage CreateStorage(string type, string name)
        {
            Storage storage = null;

            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException("Invalid storage type!");
            }

            return storage;
        }
    }
}