using System;
using System.Collections.Generic;
using System.Text;
using GRID.Tyres;

namespace GRID
{
    public class Car
    {
        public const int ConstMaxFuelAmount = 160;
        //public int MaxFuelAmount {get; private set;}
        private double fuelAmount;
        public double FuelAmount
        {
            get => this.fuelAmount;
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Not enough fuel!");
                }

                if (value > ConstMaxFuelAmount)
                {
                    this.fuelAmount = ConstMaxFuelAmount;
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }

        public int Hp { get; private set; }
        public Tyre carTyre { get; private set; }

        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.carTyre = tyre;
        }

        public void DecrementFuelAmount(double amount)
        {
            this.FuelAmount -= amount;
        }

        public void IncrementFuelAmount(double amount)
        {
            this.FuelAmount += amount;
        }

        public void ChangeTyre(Tyre tyre)
        {
            this.carTyre = tyre;
        }
    }
}
