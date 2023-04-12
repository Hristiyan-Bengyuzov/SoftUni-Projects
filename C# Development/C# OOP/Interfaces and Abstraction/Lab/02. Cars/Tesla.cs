namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Battery { get; private set; }

        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";
        public override string ToString() => $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";
    }
}
