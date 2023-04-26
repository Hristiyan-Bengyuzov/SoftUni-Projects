using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public virtual void Drive(double kilometers)
        {
            double newFuel = this.fuelQuantity - this.fuelConsumption * kilometers;

            if (newFuel < 0)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.fuelQuantity = newFuel;
                Console.WriteLine($"{this.GetType().Name} travelled {kilometers} km");
            }
        }

        public virtual void Refuel(double amount) => this.fuelQuantity += amount;

        public override string ToString() => $"{this.GetType().Name}: {this.fuelQuantity:f2}";
    }
}
