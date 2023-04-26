using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Animals.Mammals;
using WildFarm.Foods;

namespace WildFarm
{
    public static class Factory
    {
        public static Food GetFood(string[] args)
        {
            string food = args[0];
            int quantity = int.Parse(args[1]);

            switch (food)
            {
                case "Vegetable": return new Vegetable(quantity);
                case "Fruit": return new Fruit(quantity);
                case "Meat": return new Meat(quantity);
                case "Seeds": return new Seeds(quantity);
                default: return null;
            }
        }

        public static Animal GetAnimal(string[] args)
        {
            string animal = args[0];
            string name = args[1];
            double weight = double.Parse(args[2]);

            switch (animal)
            {
                case "Hen": return new Hen(name, weight, double.Parse(args[3]));
                case "Owl": return new Owl(name, weight, double.Parse(args[3]));
                case "Cat": return new Cat(name, weight, args[3], args[4]);
                case "Tiger": return new Tiger(name, weight, args[3], args[4]);
                case "Dog": return new Dog(name, weight, args[3]);
                case "Mouse": return new Mouse(name, weight, args[3]);
                default: return null;
            }
        }
    }
}
