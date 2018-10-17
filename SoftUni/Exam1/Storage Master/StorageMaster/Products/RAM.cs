using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Products
{
    class RAM : Product
    {
        private const double RAMWeight = 0.1;
        public RAM(double price)
            : base(price, RAMWeight)
        { }
    }
}
