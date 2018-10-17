using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Products
{
    class GPU : Product
    {
        private const double GpuWeight = 0.7;
        public GPU(double price) 
            : base(price, GpuWeight)
        {}
    }
}
