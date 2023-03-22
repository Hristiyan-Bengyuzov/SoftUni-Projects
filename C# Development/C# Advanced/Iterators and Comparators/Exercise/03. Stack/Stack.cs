using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> items;

        public Stack()
        {
            this.items = new List<T>();
        }

        public void Push(params T[] elements) => this.items.AddRange(elements);
       
        public T Pop()
        {
            if (this.items.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }
            else
            {
                T element = this.items[this.items.Count - 1];
                this.items.RemoveAt(this.items.Count - 1);
                return element;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
