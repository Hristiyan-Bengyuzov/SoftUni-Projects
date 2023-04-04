namespace PlayersAndMonsters
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster soulMaster = new SoulMaster("SoulMaster", 100);
            Console.WriteLine(soulMaster);

            DarkKnight darkKnight = new DarkKnight("DarkKnight", 150);
            Console.WriteLine(darkKnight);

            Hero hero = new Hero("Hero", 50);
            Console.WriteLine(hero);
        }
    }
}