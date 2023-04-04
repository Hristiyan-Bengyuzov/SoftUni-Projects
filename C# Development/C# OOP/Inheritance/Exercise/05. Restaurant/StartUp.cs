namespace Restaurant
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Coffee coffee = new Coffee("coffee", 50);
            Console.WriteLine(coffee.Milliliters);
            Console.WriteLine(coffee.Price);

            Cake cake = new Cake("sasho");
            Console.WriteLine(cake.Grams);
            Console.WriteLine(cake.Calories);
            Console.WriteLine(cake.Price);

            Fish fish = new Fish("le fishe", 10m);
            Console.WriteLine(fish.Grams);
        }
    }
}