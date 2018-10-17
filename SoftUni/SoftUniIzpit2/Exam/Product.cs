using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Product
    {
        private string type;
        private string name;
        private double price;
        public static int ordersCount;

        public Product()
        {}

        public Product(string type, string name, double price)
        {
            Type = type;
            Name = name;
            Price = price;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != value.ToUpper())
                {
                    throw new ArgumentException("Invalid type!");
                }
                this.type = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                this.price = value;
            }
        }

        public static int OrdersCount
        {
            get { return ordersCount; }
            set
            {
                ordersCount = value;
            }
        }

        public override string ToString()
        {
            return $"Product with type - {this.type} and name - {this.name}";
        }

        public static void IncreaseOrdersCount()
        {
            ordersCount += 1;
        }
    }
}
