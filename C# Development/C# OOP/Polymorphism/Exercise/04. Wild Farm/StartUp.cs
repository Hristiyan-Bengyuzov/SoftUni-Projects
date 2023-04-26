using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Foods;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0] == "End")
                {
                    break;
                }

                Animal animal = Factory.GetAnimal(tokens);
                Console.WriteLine(animal.ProduceSound());
                animals.Add(animal);

                Food food = Factory.GetFood(Console.ReadLine().Split());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
