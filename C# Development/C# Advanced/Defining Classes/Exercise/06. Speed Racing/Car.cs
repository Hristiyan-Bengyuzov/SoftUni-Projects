using System;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            double fuelToSpend = distance * this.FuelConsumptionPerKilometer;

            if (this.FuelAmount >= fuelToSpend)
            {
                this.FuelAmount -= fuelToSpend;
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString() => $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}"; 
    }
}
