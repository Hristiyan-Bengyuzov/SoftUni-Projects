using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commands[0];
                string vehicle = commands[1];
                double amount = double.Parse(commands[2]);

                if (action == "Drive")
                {
                    switch (vehicle)
                    {
                        case "Car": car.Drive(amount); break;
                        case "Truck": truck.Drive(amount); break;
                        case "Bus": bus.Drive(amount); break;
                    }
                }
                else if (action == "Refuel")
                {
                    switch (vehicle)
                    {
                        case "Car": car.Refuel(amount); break;
                        case "Truck": truck.Refuel(amount); break;
                        case "Bus": bus.Refuel(amount); break;
                    }
                }
                else
                {
                    bus.DriveEmpty(amount);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
