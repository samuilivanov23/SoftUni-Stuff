using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class VendingMachine
    {
        private string id;
        List<Product> products;
        private double totalSalesAmount;
        private double battery;

        public VendingMachine(string id)
        {
            Id = id;
            products = new List<Product>();
            TotalSalesAmount = 0;
            Battery = 100;
        }

        public VendingMachine(string id, List<Product> products)
        {
            Id = id;
            Products = products;
            TotalSalesAmount = 0;
            Battery = 100;
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value != value.ToLower() || value.Length < 3)
                {
                    throw new ArgumentException("Invalid machine id!");
                }
                this.id = value;
            }
        }

        public List<Product> Products
        {
            get { return this.products; }
            set
            {
                this.products = value;
            }
        }

        public double TotalSalesAmount
        {
            get { return this.totalSalesAmount; }
            set
            {
                this.totalSalesAmount = value;
            }
        }

        public double Battery
        {
            get { return this.battery; }
            set
            {
                if(Battery < 0)
                {
                    throw new ArgumentException("Out of battery!");
                }
                this.battery = value;
            }
        }

        public override string ToString()
        {
            Console.WriteLine($"Machine: {Id} has the following available products:");
            foreach(var product in Products)
            {
                Console.WriteLine($"Product with type - {product.Type} and name - {product.Name}");
            }

            Console.Write($"---- With total sales amount: {TotalSalesAmount.ToString("0.00")}.");
            return "";
        }

        public void Recharge()
        {
            Battery = 100;
        }

        public void ClearSales()
        {
            TotalSalesAmount = 0;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public int CheckProductQuantityOfGivenType(string type)
        {
            return Products.Where(x => x.Type == type).Count();
        }

        public void RemoveProduct(string productName)
        {
            Products.RemoveAll(x => x.Name == productName);
        }

        public Product GetMostExpensiveProduct()
        {
            double max_price =  Products.Max(x => x.Price);
            Product test_product = new Product();
            foreach(var product in Products)
            {
                if(max_price == product.Price)
                {
                    test_product = product;
                    break;
                }
            }
            return test_product;
        }

        public string SellProduct(string productName)
        {
            List<Product> product = Products.Where(x => x.Name == productName).ToList();

            if (battery - (product[0].Price * 0.8) + 2 > 0)
            {
                Battery -= (product[0].Price * 0.8) + 2;
                RemoveProduct(productName);
                TotalSalesAmount += product[0].Price;
                Product.IncreaseOrdersCount();
                return product[0].Name + " for " + product[0].Price.ToString(".00") + "lv.";
            }
            else
            {
                throw new ArgumentException("Out of battery!");
            }
        }

        public void RemoveAllProductsOfGivenType(string type)
        {
            Products.RemoveAll(x => x.Type == type);
        }

        public string GetInfoAboutAllProductsByType()
        {
            return "";
        }
    }
}
