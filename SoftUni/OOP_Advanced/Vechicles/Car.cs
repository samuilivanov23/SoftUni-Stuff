using System;
using System.Collections.Generic;
using System.Text;

namespace Vechicles
{
    class Car : IDrivable
    {
        public double FuelPerKilometre { get; private set; }

        public double FuelAmount { get; private set; }

        public double Capacity { get; private set; }

        private const double AirConditioner = 0.9;

        public Car(double fuelcount, double fuelPerKilometres, double capacity)
        {
            this.FuelAmount = fuelcount;
            this.FuelPerKilometre = fuelPerKilometres;
            this.Capacity = capacity;
        }

        public void Drive(double distance)
        {
            double neededFuel = (distance * this.FuelPerKilometre) + AirConditioner;

            if(neededFuel > this.FuelAmount)
            {
                Console.WriteLine("Car needs refueling.");
            }
            else
            {
                Console.WriteLine($"Car travelled {distance} km");
                this.FuelAmount -= neededFuel;
            }
        }

        public void ReFuel(double amount)
        {
            if(this.FuelAmount + amount >= this.Capacity)
            {
                Console.WriteLine("Can not fit.");
            }
            else
            {
                this.FuelAmount += amount;
            }
        }
    }
}
