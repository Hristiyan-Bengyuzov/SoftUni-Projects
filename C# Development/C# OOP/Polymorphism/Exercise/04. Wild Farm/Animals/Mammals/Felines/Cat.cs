using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightGain => 0.3;

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                throw new Exception($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += this.WeightGain * food.Quantity;
        }

        public override string ProduceSound() => "Meow";
    }
}
