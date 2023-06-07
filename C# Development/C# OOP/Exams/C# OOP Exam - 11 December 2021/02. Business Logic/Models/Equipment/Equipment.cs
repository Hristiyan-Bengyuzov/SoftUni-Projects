using Gym.Models.Equipment.Contracts;

namespace Gym.Models.Equipment
{
    public abstract class Equipment : IEquipment
    {
        protected Equipment(double weight, decimal price)
        {
            Weight = weight;
            Price = price;
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            private set { weight = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }
    }
}
