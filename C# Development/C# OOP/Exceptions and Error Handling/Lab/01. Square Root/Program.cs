using System;

namespace SquareRoot
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(SquareRoot(num));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        public static double SquareRoot(int num)
        {
            if (num < 0) throw new ArgumentException("Invalid number.");
            return Math.Sqrt(num);
        }
    }
}