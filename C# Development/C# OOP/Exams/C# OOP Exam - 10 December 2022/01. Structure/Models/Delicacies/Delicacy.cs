using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies
{
    public abstract class Delicacy : IDelicacy
    {
        protected Delicacy(string name, double price)
        {
            Name = name;
            Price = price;
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }

                name = value;
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public override string ToString()
        {
            return $"{Name} - {Price:f2} lv";
        }
    }
}
