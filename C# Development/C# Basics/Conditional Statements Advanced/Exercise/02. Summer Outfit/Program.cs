using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            var (outfit, shoes) = time switch
            {
                "Morning" when degree is >= 10 and <= 18 => ("Sweatshirt", "Sneakers"),
                "Morning" when degree is > 18 and <= 24 => ("Shirt", "Moccasins"),
                "Morning" when degree is > 24 => ("T-Shirt", "Sandals"),
                "Afternoon" when degree is >= 10 and <= 18 => ("Shirt", "Moccasins"),
                "Afternoon" when degree is > 18 and <= 24 => ("T-Shirt", "Sandals"),
                "Afternoon" when degree is > 24 => ("Swim Suit", "Barefoot"),
                "Evening" when degree is >= 10 and <= 18 => ("Shirt", "Moccasins"),
                "Evening" when degree is > 18 and <= 24 => ("Shirt", "Moccasins"),
                "Evening" when degree is > 24 => ("Shirt", "Moccasins"),
                _ => (null, null)
            };

            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}