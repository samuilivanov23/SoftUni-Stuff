using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Products
{
    class SolidStateDrive : Product
    {
        private const double SSDWeight = 0.2;
        public SolidStateDrive(double price)
            : base(price, SSDWeight)
        { }
    }
}
