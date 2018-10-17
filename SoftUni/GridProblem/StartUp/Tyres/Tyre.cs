using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Tyres
{
    public class Tyre
    {
        private const int DegradationCount = 100;
        private double degradation;
        public string Name { get; private set; }
        public double Hardness { get; private set; }
        public double Degradation
        {
            get => this.degradation;
            protected set
            {
                if (this.Degradation < 0)
                {
                    throw new InvalidOperationException("Blown Tyre");
                }
                this.degradation = value;
            }
        }

        protected Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.Degradation = DegradationCount;
        }
       
        public virtual bool HasTyreLive => this.Degradation < 0;

        public virtual void DecreaseDegradation()
        {
            this.Degradation -= this.Hardness;
        }
    }
}
