using System;
using System.Collections.Generic;
using System.Text;

namespace GRID.Drivers
{
    public class Driver
    {
        public string Name { get; private set; }
        public double TotalTime { get; private set; }
        public Car driverCar { get; private set; }
        public double FuelConsumptionPerKm { get; private set; }
        public double Speed { get; set; }
        public string FailureReason { get; private set; }

        protected Driver(string name, Car car)
        {
            this.Name = name;
            this.driverCar = car;
            this.Speed = (driverCar.Hp + driverCar.carTyre.Degradation) / driverCar.FuelAmount;
        }

        public void SetFailureReason(string reason)
        {
            this.FailureReason = reason;
        }

        public virtual void ChangeSpeed()
        {
            this.Speed = (driverCar.Hp + driverCar.carTyre.Degradation) / driverCar.FuelAmount;
        }

        public void IncrementTotalTime(double time)
        {
            this.TotalTime += time;
        }
    }
}
