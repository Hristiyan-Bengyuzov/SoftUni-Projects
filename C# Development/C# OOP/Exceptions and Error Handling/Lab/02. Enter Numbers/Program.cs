using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            while (nums.Count < 10)
            {
                try
                {
                    if (!nums.Any())
                    {
                        nums.Add(ReadNumber(1, 100));
                    }
                    else
                    {
                        nums.Add(ReadNumber(nums.Max(), 100));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }

        static int ReadNumber(int start, int end)
        {
            int num;

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Number!");
            }

            if (num <= start || num >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - {end}!");
            }

            return num;
        }
    }
}