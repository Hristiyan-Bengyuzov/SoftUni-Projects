using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine, int? weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.Append($"    Displacement: ");
            sb.AppendLine(this.Engine.Displacement.HasValue ? $"{this.Engine.Displacement}" : "n/a");
            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            sb.Append($"  Weight: ");
            sb.AppendLine(this.Weight.HasValue ? $"{this.Weight}" : "n/a");
            sb.Append($"  Color: {this.Color}");
            return sb.ToString();
        }
    }
}
