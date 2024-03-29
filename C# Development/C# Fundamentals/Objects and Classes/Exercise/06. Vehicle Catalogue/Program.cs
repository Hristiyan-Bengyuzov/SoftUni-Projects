﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] command = Console.ReadLine().Split();

            var vehicles = new List<Vehicle>();

            while (command[0] != "End")
            {
                VehicleType type;

                bool isSuccessful = Enum.TryParse(command[0], true, out type);

                if (isSuccessful)
                {
                    string model = command[1], color = command[2];
                    int hp = int.Parse(command[3]);

                    var vehicle = new Vehicle(type, model, color, hp);
                    vehicles.Add(vehicle);
                }
                command = Console.ReadLine().Split();
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue") break;
               
                var vehicleToCheck = vehicles.FirstOrDefault(x => x.Model == input);
                
                Console.WriteLine(vehicleToCheck);
            }

            var cars = vehicles.Where(x => x.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(t => t.Type == VehicleType.Truck).ToList();

            var carsAvgHp = cars.Count > 0 ? cars.Average(hp => hp.Horsepower) : 0.00;
            var trucksAvgHp = trucks.Count > 0 ? trucks.Average(hp => hp.Horsepower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}.");

        }
    }
    enum VehicleType
    {
        Car,
        Truck
    }
    class Vehicle
    {
        public Vehicle(VehicleType type, string model, string color, int hp)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = hp;
        }
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine($"Type: {Type}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Color: {Color}");
            output.AppendLine($"Horsepower: {Horsepower}");
            return output.ToString().TrimEnd();
        }
    }
}