namespace NeedForSpeed
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            FamilyCar familyCar = new FamilyCar(100, 200);
            familyCar.Drive(10);
            Console.WriteLine(familyCar.Fuel);

            SportCar sportCar = new SportCar(100, 200);
            sportCar.Drive(10);
            Console.WriteLine(sportCar.Fuel);

            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(100, 200);
            raceMotorcycle.Drive(10);
            Console.WriteLine(raceMotorcycle.Fuel);

            CrossMotorcycle crossMotorcycle = new CrossMotorcycle(100, 200);
            crossMotorcycle.Drive(10);
            Console.WriteLine(crossMotorcycle.Fuel);
        }
    }
}
