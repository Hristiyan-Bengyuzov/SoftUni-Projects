using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                sum = letter switch
                {
                    'a' => sum + 1,
                    'e' => sum + 2,
                    'i' => sum + 3,
                    'o' => sum + 4,
                    'u' => sum + 5,
                    _ => sum
                };
                
            }
            Console.WriteLine(sum);
        }
    }
}
