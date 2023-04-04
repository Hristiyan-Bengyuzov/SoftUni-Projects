namespace Zoo
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Gorilla gorilla = new Gorilla("monke");
            Snake snake = new Snake("kobrata");

            Console.WriteLine(gorilla.Name);
            Console.WriteLine(snake.Name);
        }
    }
}