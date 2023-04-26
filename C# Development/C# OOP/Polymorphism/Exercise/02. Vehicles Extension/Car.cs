namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double CONSUMPTION_INCREASE = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + CONSUMPTION_INCREASE, tankCapacity)
        {
        }
    }
}
