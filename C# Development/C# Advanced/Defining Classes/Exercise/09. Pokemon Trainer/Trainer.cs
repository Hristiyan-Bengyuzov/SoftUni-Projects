using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public override string ToString() => $"{this.Name} {this.Badges} {this.Pokemons.Count}";
    }
}
