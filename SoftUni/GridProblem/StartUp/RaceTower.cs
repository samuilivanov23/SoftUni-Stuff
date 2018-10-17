using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GRID.Drivers;
using GRID.Tyres;

namespace GRID
{
    using System;
    using System.Collections.Generic;
    using GRID.Drivers;
    using GRID.Tyres;

    public class RaceTower
    {
        public int LapsNumber { get; private set; }
        public int TrackLength { get; private set; }
        public int CurrentLap { get; private set; }
        Dictionary<string, Driver> drivers = new Dictionary<string, Driver>();
        Stack<Driver> failures = new Stack<Driver>();

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.LapsNumber = lapsNumber;
            this.TrackLength = trackLength;
        }

        public void RegisterDriver(List<string> commandArgs)
        {
            Driver driver = CreateDriver(commandArgs);
            if (driver != null)
            {
                drivers.Add(driver.Name, driver);
            }
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            string driverName = commandArgs[1];
            Driver driver = drivers[driverName];
            driver.IncrementTotalTime(20);

            string command = commandArgs[0];

            switch (command)
            {
                case "Refuel":
                    double fuelAmount = double.Parse(commandArgs[2]);
                    driver.driverCar.IncrementFuelAmount(fuelAmount);
                    break;
                case "ChangeTyres":
                    string tyreType = commandArgs[2];
                    switch (tyreType)
                    {
                        case "Hard":
                            double hardness = double.Parse(commandArgs[3]);
                            driver.driverCar.ChangeTyre(new HardTyre(hardness));
                            break;
                        case "Ultrasoft":
                            double hardness_ = double.Parse(commandArgs[3]);
                            double grip = double.Parse(commandArgs[4]);
                            driver.driverCar.ChangeTyre(new UltrasoftTyre(hardness_, grip));
                            break;
                    }
                    break;
            }
        }

        public string CompleteLaps(List<string> commandArgs)
        {
            int lapsNumber = int.Parse(commandArgs[0]);
            string result = $"";

            if (lapsNumber > this.LapsNumber - this.CurrentLap)
            {
                result = $"There is no time! On lap {this.CurrentLap}.";
                return result;
            }
            else
            {
                this.CurrentLap += lapsNumber;
                double totaltimeIncrement;
                double fuelDecrementValue;

                for (int i = 0; i < lapsNumber; i++)
                {
                    foreach (var driver in drivers)
                    {
                        if(driver.Value.driverCar.FuelAmount < 0)
                        {
                            failures.Push(driver.Value);
                            driver.Value.SetFailureReason("Out of fuel");
                            drivers.Remove(driver.Key);
                        }

                        if (driver.Value.driverCar.carTyre.GetType().Name == "HardTyre")
                        {
                            if(driver.Value.driverCar.carTyre.Degradation < 0)
                            {
                                failures.Push(driver.Value);
                                driver.Value.SetFailureReason("Blown Tyre");
                                drivers.Remove(driver.Key);
                            }
                        }
                        else
                        {
                            if(driver.Value.driverCar.carTyre.Degradation < 30)
                            {
                                failures.Push(driver.Value);
                                driver.Value.SetFailureReason("Blown Tyre");
                                drivers.Remove(driver.Key);
                            }
                        }

                        totaltimeIncrement = 60 / (this.TrackLength / driver.Value.Speed);
                        fuelDecrementValue = this.TrackLength * driver.Value.FuelConsumptionPerKm;

                        driver.Value.IncrementTotalTime(totaltimeIncrement);
                        driver.Value.driverCar.DecrementFuelAmount(fuelDecrementValue);
                        driver.Value.driverCar.carTyre.DecreaseDegradation();
                    }
                }
                return result;
            }
        }

        public string GetLeaderboard()
        {
            string firsLine = $"Lap {this.CurrentLap}/{this.LapsNumber}";

            Dictionary<string, Driver> sortedDrivers = drivers
                                                        .OrderBy(x => x.Value.TotalTime)
                                                        .ToDictionary(x => x.Key, y => y.Value);

            string[] rankingLines = new string[sortedDrivers.Count];
            int index = 0;
            foreach (var driver in sortedDrivers)
            {
                Driver Currdrive = driver.Value;
                rankingLines[index] = $"{index + 1} {driver.Key}" + " " + Currdrive.TotalTime.ToString("0.000"); // Add failure reason
                index++;
            }

            if(failures.Count > 0)
            {
                string[] failureRanking = new string[failures.Count];
                int index_ = 0;
                foreach (var driver in failures)
                {
                    failureRanking[index_] = $"{index_ + 1} {driver.Name}" + " " + driver.FailureReason; // Add failure reason
                    index_++;
                }
            }

            string output = firsLine + Environment.NewLine;
            foreach (var line in rankingLines)
            {
                output += line + Environment.NewLine;
            }

            if(failures.Count > 0)
            {
                foreach (var line in failures)
                {
                    output += line + Environment.NewLine;
                }
            }

            return output.Trim();
        }

        private Driver CreateDriver(List<string> commandArgs)
        {
            Driver driver = null;
            Car car = null;
            Tyre tyre = null;
            string driverType = commandArgs[0];
            string tyreType = commandArgs[4];
            switch (driverType)
            {
                case "Aggressive":
                    switch (tyreType)
                    {
                        case "Ultrasoft":
                            double tyreHardness = double.Parse(commandArgs[5]);
                            double tyreGrip = double.Parse(commandArgs[6]);
                            tyre = new UltrasoftTyre(tyreHardness, tyreGrip);
                            int carHp = int.Parse(commandArgs[2]);
                            double carFuelAmount = double.Parse(commandArgs[3]);
                            car = new Car(carHp, carFuelAmount, tyre);
                            string driverName = commandArgs[1];
                            driver = new AggressiveDriver(driverName, car);
                            break;
                        case "Hard":
                            double tyreHardness_ = double.Parse(commandArgs[5]);
                            tyre = new HardTyre(tyreHardness_);
                            int carHp_ = int.Parse(commandArgs[2]);
                            double carFuelAmount_ = double.Parse(commandArgs[3]);
                            car = new Car(carHp_, carFuelAmount_, tyre);
                            string driverName_ = commandArgs[1];
                            driver = new AggressiveDriver(driverName_, car);
                            break;
                    }
                    break;
                case "Endurance":
                    switch (tyreType)
                    {
                        case "Ultrasoft":
                            double tyreHardness = double.Parse(commandArgs[5]);
                            double tyreGrip = double.Parse(commandArgs[6]);
                            tyre = new UltrasoftTyre(tyreHardness, tyreGrip);
                            int carHp = int.Parse(commandArgs[2]);
                            double carFuelAmount = double.Parse(commandArgs[3]);
                            car = new Car(carHp, carFuelAmount, tyre);
                            string driverName = commandArgs[1];
                            driver = new AggressiveDriver(driverName, car);
                            break;
                        case "Hard":
                            double tyreHardness_ = double.Parse(commandArgs[5]);
                            tyre = new HardTyre(tyreHardness_);
                            int carHp_ = int.Parse(commandArgs[2]);
                            double carFuelAmount_ = double.Parse(commandArgs[3]);
                            car = new Car(carHp_, carFuelAmount_, tyre);
                            string driverName_ = commandArgs[1];
                            driver = new AggressiveDriver(driverName_, car);
                            break;
                    }
                    break;
            }

            return driver;
        }
    }
}