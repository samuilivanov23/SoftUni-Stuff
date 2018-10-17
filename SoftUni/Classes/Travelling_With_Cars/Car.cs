using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_With_Cars
{
    class Car
    {
        private string model;
        public double current_fuel;
        private double fuel_per_km;
        public double distance_traveled;

        public Car()
        {}

        public Car(string model, double current_fuel, double fuel_per_hour)
        {
            Model = model;
            Current_Fuel = current_fuel;
            Fuel_Per_KM = fuel_per_hour;
            Distance_Traveled = 0;
        }

        public string Model
        {
            get { return model;}
            set { model = value; }
        }

        public double Current_Fuel
        {
            get { return current_fuel; }
            set { current_fuel = value; }
        }

        public double Fuel_Per_KM
        {
            get { return fuel_per_km; }
            set { fuel_per_km = value; }
        }

        public double Distance_Traveled
        {
            get { return distance_traveled; }
            set { distance_traveled = value; }
        }

        public void CanDrive(double kilometres)
        {
            if (this.fuel_per_km * kilometres <= this.current_fuel)
            {
                this.current_fuel -= (this.fuel_per_km * kilometres);
                this.distance_traveled += kilometres;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
