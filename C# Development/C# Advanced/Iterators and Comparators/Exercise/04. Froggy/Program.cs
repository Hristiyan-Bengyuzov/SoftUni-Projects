﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        static void Main()
        {
            List<int> stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Lake lake = new Lake(stones);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
