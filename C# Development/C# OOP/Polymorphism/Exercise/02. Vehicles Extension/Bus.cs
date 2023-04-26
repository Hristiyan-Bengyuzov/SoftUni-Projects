namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double CONSUMPTION_INCREASE = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double kilometers)
        {
            base.fuelConsumption += CONSUMPTION_INCREASE;
            base.Drive(kilometers);
            base.fuelConsumption -= CONSUMPTION_INCREASE;
        }
        public void DriveEmpty(double kilometers) => base.Drive(kilometers);
    }
}