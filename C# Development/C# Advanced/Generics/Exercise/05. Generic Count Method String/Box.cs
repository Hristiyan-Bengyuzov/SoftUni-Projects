using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodString
{
    public class Box<T>
    {
        private T boxValue;

        public T BoxValue { get => this.boxValue; set => this.boxValue = value; }

        public Box(T entry)
        {
            this.boxValue = entry;
        }

        public static int GetCountOfLargerElements(List<Box<T>> list, T item) => list.Count(x => Comparer<T>.Default.Compare(x.BoxValue, item) > 0);
    }
}
