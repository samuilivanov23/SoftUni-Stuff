using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StorageMaster.Products;

namespace StorageMaster.Vehicles
{
    public abstract class Vehicle
    {
        public int Capacity { get; private set; }
        private List<Products.Product> trunk;

        protected Vehicle(int capacity)
        {
            Capacity = capacity;
            this.trunk = new List<Products.Product>();
        }

        public IReadOnlyCollection<Products.Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.trunk.Sum(x => x.Weight) == Capacity;

        public bool IsEmpty => this.trunk.Count == 0;

        public void LoadProduct(Products.Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Products.Product product = this.trunk[this.trunk.Count - 1];
            this.trunk.RemoveAt(this.trunk.Count - 1);
            return product;
        }
    }
}
