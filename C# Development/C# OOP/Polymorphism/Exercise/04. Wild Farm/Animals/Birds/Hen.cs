using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightGain => 0.35;

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += this.WeightGain * food.Quantity;
        }

        public override string ProduceSound() => "Cluck";
    }
}
