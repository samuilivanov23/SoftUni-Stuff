﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Vehicles
{
    public class Semi : Vehicle
    {
        private const int capacity = 2;
        public Semi()
            : base(capacity)
        {
        }
    }
}
