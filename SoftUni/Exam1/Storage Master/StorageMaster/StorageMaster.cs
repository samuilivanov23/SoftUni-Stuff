using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Products;
using StorageMaster.Storages;
using StorageMaster.Vehicles;
using System.Linq;


namespace StorageMaster
{
    public class StorageMaster
    {

        private Dictionary<string, Stack<Product>> products;
        private Dictionary<string, Storage> storages;
        private Vehicle currentvehicle;

        public StorageMaster()
        {
            products = new Dictionary<string, Stack<Product>>();
            storages = new Dictionary<string, Storage>();
        }

        public Product CreateProduct(string type, double price)
        {
            Product product = null;

            switch (type)
            {
                case "Gpu":
                    product = new GPU(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "RAM":
                    product = new RAM(price);
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

        public string AddProduct(string type, double price)
        {
            Product product = CreateProduct(type, price);
            if (!this.products.ContainsKey(type))
            {
                this.products[type].Push(product);
            }

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = CreateStorage(type, name);
            this.storages.Add(storage);

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);

            this.currentvehicle = vehicle;

            return $"Selected {vehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int counter;
            foreach (string ProductName in productNames)
            {
                if (this.products.ContainsKey(ProductName) && products.Count == > 0)
                {
                    Product product = this.products[ProductName].Pop();


                }
                if (!this.products.ContainsKey(ProductName))
                {
                    throw new InvalidOperationException($"{ProductName} is out of stock!");
                }
            }

            return $"Loaded {loadedProductsCount}/{productNames.Count()} products into {this.currentvehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            throw new NotImplementedException();
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);

            int UnloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {UnloadedProductsCount}/{vehicle.Trunk.Count} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];

            Dictionary<string, int> productCounts = new Dictionary<string, int>();

            foreach (Product product in storage.Products)
            {
                string type = product.GetType().Name;
                if (!productCounts.ContainsKey(type))
                {
                    productCounts.Add(type, 0);
                }

                productCounts[type]++;
            }
            string[] productInfo = productCounts.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => $"{x.Key} {x.Value}").ToArray();

            double productWhenSum = storage.Products.Sum(x => x.Weight);
            string StockLine = $"{productWhenSum}/{storage.Capaticy}: {string.Join(", ", productWhenSum)}";


            string[] garageNames = storage.Garage.Select(g =>
            {
                string result;
                result = g == null ? "empty" : g.GetType().Name;
                return result;
            }
            ).ToArray();

            string garageLine = $"Garage: {String.Join(", ", garageNames)}";

            string  result_ = StockLine + Environment.NewLine + garageLine;
            return result_;
        }

        public string GetSummary()
        {
            var sortedStorages = this.storages.OrderByDescending(x => x.Value.Products.Sum(y => y.Price)).ToDictionary(p => p.Key, p => p.Value);
            StringBuilder sb = new StringBuilder();
            foreach (var storage in sortedStorages)
            {
                double totalMoney = storage.Value.Products.Sum(p => p.Price);
                sb.Append($"{storage.Key}");
                sb.Append($"Storage worth: {totalMoney : F2}");
            }

            string result = sb.ToString();
            return result;
        }
    }
}
