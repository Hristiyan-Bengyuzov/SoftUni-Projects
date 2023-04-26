using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        public abstract double WeightGain { get; }

        public abstract string ProduceSound();
        public abstract void Eat(Food food);
    }
}
