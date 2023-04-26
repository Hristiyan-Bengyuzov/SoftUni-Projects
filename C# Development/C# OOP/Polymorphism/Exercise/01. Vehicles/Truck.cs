namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double CONSUMPTION_INCREASE = 1.6;
        private const double REFUEL_MODIFIER = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + CONSUMPTION_INCREASE)
        {
        }

        public override void Refuel(double kilometers) => base.Refuel(kilometers * REFUEL_MODIFIER);
    }
}
