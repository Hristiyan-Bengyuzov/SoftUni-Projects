namespace FoodShortage
{
    public abstract class Buyer : IBuyer
    {
        protected Buyer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public int Food { get; set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public virtual void BuyFood() // method to be overriden by children
        {
        }
    }
}
