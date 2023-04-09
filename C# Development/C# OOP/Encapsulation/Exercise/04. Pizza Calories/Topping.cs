using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        private const int CaloriesPerGram = 2;

        private Dictionary<string, double> types = new Dictionary<string, double>
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9},
        };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public double Calories => CaloriesPerGram * this.Weight * types[this.Type.ToLower()];
        public string Type
        {
            get => type;
            private set
            {
                if (!types.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new InvalidOperationException($"{this.type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }
    }
}