using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int sum = 0;

            foreach (var element in input)
            {
                try
                {
                    ValidateInput(element, ref sum);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }

        static void ValidateInput(string input, ref int sum)
        {
            int num;

            try
            {
                num = int.Parse(input);
            }
            catch (FormatException)
            {
                throw new FormatException($"The element '{input}' is in wrong format!");
            }
            catch (OverflowException)
            {
                throw new OverflowException($"The element '{input}' is out of range!");
            }

            sum += num;
        }
    }
}
