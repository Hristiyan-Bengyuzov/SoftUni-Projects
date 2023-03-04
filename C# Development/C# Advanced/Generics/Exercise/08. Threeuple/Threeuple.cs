namespace Threeuple
{
    public class Threeuple<T1, T2, T3>
    {
        private T1 first;
        private T2 second;
        private T3 third;

        public T1 First { get => this.first; set => this.first = value; }
        public T2 Second { get => this.second; set => this.second = value; }
        public T3 Third { get => this.third; set => this.third = value; }

        public Threeuple(T1 first, T2 second, T3 third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

        public override string ToString() => $"{this.First} -> {this.Second} -> {this.Third}";
    }
}