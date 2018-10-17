using System;
using System.Collections.Generic;
using System.Text;

namespace FarmVille
{
    public abstract class Animal
    {
        public string AnimalName { get; private set; }
        public string AnimalType { get; private set; }
        public double AnimalWeight { get; private set; }
        public int FoodEaten { get; private set; }

        protected Animal(string animalName, string animalType, double animalWight, int foodEaten)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWight;
            this.FoodEaten = foodEaten;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public virtual void MakeSound()
        {

        }

        public virtual void EatFood(int food)
        {
            this.FoodEaten += food;
        }

    }
}
