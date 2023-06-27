using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {

        protected Cocktail(string name, string size, double price)
        {
            Name = name;
            Size = size;
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

        private string size;

        public string Size
        {
            get { return size; }
            private set { size = value; }
        }


        private double price;

        public double Price
        {
            get { return price; }
            private set
            {
                if (Size == "Large")
                {
                    this.price = value;
                }
                else if (Size == "Middle")
                {
                    this.price = 2.0 / 3 * value;
                }
                else
                {
                    this.price = 1.0 / 3 * value;
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Size}) - {Price:f2} lv";
        }

    }
}
