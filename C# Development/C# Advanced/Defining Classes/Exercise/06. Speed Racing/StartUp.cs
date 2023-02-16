using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int countOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, new Car(model, double.Parse(carInfo[1]), double.Parse(carInfo[2])));
                }
            } // adding cars to dictionary

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                double distance = double.Parse(tokens[2]);

                if (tokens[0] == "Drive")
                {
                    cars[model].Drive(distance);
                }

                command = Console.ReadLine();
            } // main logic

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            } // printing
        }
    }
}
