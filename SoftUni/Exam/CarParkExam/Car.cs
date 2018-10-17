using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam
{
    class Car
    {
        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts = new List<Part>;
        private int fuel;
        private string name;
        private double price;

        public Car(string manufacturer, string model, double loadCapacity)
        {
            Manufacturer = manufacturer;
            Model = model;
            LoadCapacity = loadCapacity;
            Fuel = 100;
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get { return this.Model; }
            set
            {
                this.Model = value;
            }
        }

        public double LoadCapacity
        {
            get { return this.loadCapacity; }
            set
            {
                this.loadCapacity = value;
            }
        }

        public List<Part> Parts
        {
            get { return this.parts; }
            set
            {
                this.parts = value;
            }
        }

        public int Fuel
        {
            get { return this.fuel; }
            set
            {
                this.fuel = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public double Price
        {
            get { return Parts.Sum(x => x.Price); }
            set
            {
                this.price = value;
            }
        }

        public void PrintCarByModel()
        {
            
        }
    }
}
