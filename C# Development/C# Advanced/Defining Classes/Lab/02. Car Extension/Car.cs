using System;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get => this.make;
            set => this.make = value;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public int Year
        {
            get => this.year;
            set => this.year = value;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set => this.fuelQuantity = value;
        }

        public double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        public void Drive(double distance)
        {
            if (this.FuelQuantity - (this.FuelConsumption * distance) >= 0)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:F2}");

            return sb.ToString().Trim();
        }
    }
}
