using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge()
        {
            head = new Product();
            tail = new Product();
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public void AddProduct(string ProductName)
        {
            if (this.Count == 0)
            {
                head.Name = ProductName;
                tail.Name = ProductName;
                head.Next = null;
                tail.Next = null;
                this.Count++;
            }
            else if(this.Count == 1)
            {
                Product temp = new Product(ProductName, this.tail);
                this.tail = temp;
                this.head.Next = temp;
                this.Count++;
            }
            else
            {
                Product temp = new Product(ProductName, this.tail);
                this.tail = temp;
                this.Count++;
            }
        }

        public string[] CookMeal(int start, int end)
        {
            string[] names = new string[this.Count];
            int string_index = 0;
            Product currentProduct = this.head;
            Product previousProduct = this.tail;
            int currentIndex = 0;

            while(currentProduct != null || currentIndex < this.Count)
            {
                if(currentIndex >= start && currentIndex <= end)
                {
                    names[string_index] = currentProduct.Name;
                    string_index++;
                    currentIndex++;
                    currentProduct = currentProduct.Next;
                }
                else
                {
                    previousProduct = currentProduct;
                    currentProduct = currentProduct.Next;
                    currentIndex++;
                }
            }
            return names;
        }

        public string RemoveProductByIndex(int index)
        {
            int currentIndex = 0;
            Product currentProduct = this.head;
            Product previousProduct = null;

            while (currentProduct != null)
            {
                if(currentIndex == index)
                {
                    if(previousProduct != null)
                    {
                        previousProduct.Next = currentProduct.Next;
                    }
                    else
                    {
                        this.head = currentProduct.Next;
                    }

                    if(currentProduct == null)
                    {
                        this.tail = previousProduct;
                    }
                    Count--;
                    return currentProduct.Name;
                }
                else
                {
                    previousProduct = currentProduct;
                    currentProduct = currentProduct.Next;
                    currentIndex++;
                }
            }
            return null;
        }

        public int IndexOf(string name)
        {
            Product currentProduct = this.head;
            Product previousProduct = this.tail;
            int currentIndex = 0;

            while (currentProduct != null)
            {
                if(currentProduct.Name == name)
                {
                    return currentIndex;
                }
                else
                {
                    previousProduct = currentProduct;
                    currentProduct = currentProduct.Next;
                    currentIndex++;
                }
            }
            return -1;
        }

        public string RemoveProductByName(string name)
        {
            int index = IndexOf(name);
            name = this.RemoveProductByIndex(index);
            return name;
        }

        public bool CheckProductIsInStock(string name)
        {
            return IndexOf(name) > -1;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            Product currentProduct = this.head;
            string[] names = new string[this.Count];
            int currentIndex = 0;

            while(currentProduct != null)
            {
                names[currentIndex] = "Product " + currentProduct.Name;
                currentProduct = currentProduct.Next;
                currentIndex++;
            }

            return names;
        }
    }
}
