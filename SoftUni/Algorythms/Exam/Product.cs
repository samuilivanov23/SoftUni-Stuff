using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Product
    {
        private string name;
        private Product next;

        public Product(){}

        public Product(string name)
        {
            Name = name;
            Next = null;
        }

        public Product(string name, Product prev)
        {
            Name = name;
            prev.Next = this;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Product Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Product {Name}";
        }
    }
}
