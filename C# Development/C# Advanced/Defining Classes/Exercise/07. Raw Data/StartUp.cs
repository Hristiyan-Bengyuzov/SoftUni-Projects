using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int countOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                Engine engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                Cargo cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(carInfo[5]),int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]),int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]),int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]),int.Parse(carInfo[12]))
                };

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else // flammable
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == command && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
