using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }

        public string RandomString()
        {
            int index = this.random.Next(Count);
            string stringToRemove = this[index];
            this.RemoveAt(index);
            return stringToRemove;
        }
    }
}
