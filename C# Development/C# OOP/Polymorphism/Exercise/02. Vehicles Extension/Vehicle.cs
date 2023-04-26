using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
            if (fuelQuantity <= this.tankCapacity)
            {
                this.fuelQuantity = fuelQuantity;
            }
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

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (this.fuelQuantity + liters > this.tankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.fuelQuantity += liters;
            }
        }

        public override string ToString() => $"{this.GetType().Name}: {this.fuelQuantity:f2}";
    }
}
