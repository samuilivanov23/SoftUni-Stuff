using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    public abstract class Food
    {
        public int Quantity { get; private set; }

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
