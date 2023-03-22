using System;
using System.Collections;
using System.Collections.Generic;


namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
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

        public void PrintAll()
        {
            if (this.elements.Count != 0)
                Console.WriteLine(string.Join(" ", this.elements));
            else
                Console.WriteLine("Invalid Operation!");
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
