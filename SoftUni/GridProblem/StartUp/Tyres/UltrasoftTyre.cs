using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Tyres
{
    class UltrasoftTyre : Tyre
    {
        private const string TyreName = "Ultrasoft";
        public double Grip{ get; private set; }

        public UltrasoftTyre(double hardness, double grip)
            :base(TyreName, hardness)
        {
            this.Grip = grip;
        }

        public override void DecreaseDegradation()
        {
            this.Degradation -= this.Hardness + this.Grip;
        }

        public override bool HasTyreLive => this.Degradation < 30;
    }
}
