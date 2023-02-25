using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;

        public Box()
        {
            this.stack = new Stack<T>();
        }

        public void Add(T item) => this.stack.Push(item);

        public T Remove() => this.stack.Pop();

        public int Count => this.stack.Count;
    }
}
