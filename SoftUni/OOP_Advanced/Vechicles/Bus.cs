using System;
using System.Collections.Generic;
using System.Text;

namespace Vechicles
{
    class Bus : IDrivable
    {
        public double FuelPerKilometre { get; private set; }

        public double FuelAmount { get; private set; }

        public double Capacity { get; private set; }

        public bool PeopleCarried { get; private set; }


        private const double AirConditioner = 1.4;

        public Bus(double fuelcount, double fuelPerKilometres)
        {
            this.FuelAmount = fuelcount;
            this.FuelPerKilometre = fuelPerKilometres;
            this.Capacity = Capacity;
        }

        public void Drive(double distance)
        {

            double neededFuel;

            if (PeopleCarried)
            {
                neededFuel = (distance * this.FuelPerKilometre) + AirConditioner;
            }
            else
            {
                neededFuel = (distance * this.FuelPerKilometre);
            }
            if (neededFuel > this.FuelAmount)
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
            if (this.FuelAmount + amount >= this.Capacity)
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
