using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Tyres
{
    public class HardTyre : Tyre
    {
        private const string TyreName = "Hard";
        public HardTyre(double hardness) 
            : base(TyreName, hardness)
        {
        }
    }
}
