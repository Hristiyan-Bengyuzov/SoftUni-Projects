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
            List<Engine> engines = new List<Engine>();
            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (engineInfo.Length == 2) // displacement and efficiency are missing
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), null, "n/a"));
                }
                else if (engineInfo.Length == 3) // displacement or efficiency is missing
                {
                    if (int.TryParse(engineInfo[2], out int result)) // efficiency is missing
                    {
                        engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), result, "n/a"));
                    }
                    else // displacement is missing
                    {
                        engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), null, engineInfo[2]));
                    }
                }
                else // nothing is missing
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]));
                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine engine = engines.First(x => x.Model == carInfo[1]);

                if (carInfo.Length == 2) // weight and color are missing
                {
                    cars.Add(new Car(carInfo[0], engine, null, "n/a"));
                }
                else if (carInfo.Length == 3) // weight or color is missing
                {
                    if (int.TryParse(carInfo[2], out int result)) // color is missing
                    {
                        cars.Add(new Car(carInfo[0], engine, result, "n/a"));
                    }
                    else // weight is missing
                    {
                        cars.Add(new Car(carInfo[0], engine, null, carInfo[2]));
                    }
                }
                else // nothing is missing
                {
                    cars.Add(new Car(carInfo[0], engine, int.Parse(carInfo[2]), carInfo[3]));
                }
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}