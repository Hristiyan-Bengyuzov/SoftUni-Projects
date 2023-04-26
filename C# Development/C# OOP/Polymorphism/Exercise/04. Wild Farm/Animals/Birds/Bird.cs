namespace WildFarm.Animals.Birds
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString() => $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}
