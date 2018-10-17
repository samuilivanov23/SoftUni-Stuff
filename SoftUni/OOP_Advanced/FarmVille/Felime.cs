using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    public abstract class Felime : Mammal
    {
        protected Felime(string animalName, string animalType, double animalWight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWight, foodEaten, livingRegion)
        {
        }

        public override void MakeSound()
        {
            base.MakeSound();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
