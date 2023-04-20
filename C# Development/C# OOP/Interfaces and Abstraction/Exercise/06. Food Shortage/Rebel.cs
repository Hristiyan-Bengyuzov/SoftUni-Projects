namespace FoodShortage
{
    public class Rebel : Buyer
    {
        public Rebel(string name, int age, string group) : base(name, age)
        {
            this.Group = group;
        }

        public string Group { get; private set; }

        public override void BuyFood() => this.Food += 5;
    }
}
