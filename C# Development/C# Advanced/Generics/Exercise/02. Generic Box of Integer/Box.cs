namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private T boxValue;

        public T BoxValue { get => this.boxValue; set => this.boxValue = value; }

        public Box(T entry)
        {
            this.boxValue = entry;
        }

        public override string ToString() => $"{this.BoxValue.GetType()}: {this.BoxValue}";
    }
}