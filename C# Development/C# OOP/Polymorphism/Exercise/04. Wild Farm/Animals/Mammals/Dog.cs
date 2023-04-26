using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double WeightGain => 0.4;

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new Exception($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += this.WeightGain * food.Quantity;
        }

        public override string ProduceSound() => "Woof!";
    }
}
