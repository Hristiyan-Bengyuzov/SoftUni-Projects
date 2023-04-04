namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }

        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get => this.DefaultFuelConsumption; }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }
    }
}
