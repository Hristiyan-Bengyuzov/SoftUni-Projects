using System;
using System.Collections.Generic;


namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private int currentIndex;
        private List<T> elements;

        public ListyIterator(params T[] entries)
        {
            this.elements = new List<T>(entries);
            this.currentIndex = 0;
        }


        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext() => this.currentIndex < this.elements.Count - 1;

        public void Print()
        {
            if (this.elements.Count != 0)
                Console.WriteLine(this.elements[currentIndex]);
            else
                Console.WriteLine("Invalid Operation!");
        }
    }
}
