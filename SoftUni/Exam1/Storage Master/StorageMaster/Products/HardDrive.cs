﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Products
{
    class HardDrive : Product
    {
        private const double HardDriveWeight = 1;
        public HardDrive(double price)
            : base(price, HardDriveWeight)
        { }
    }
}
