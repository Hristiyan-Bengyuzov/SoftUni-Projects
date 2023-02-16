namespace DefiningClasses
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int hp)
        {
            this.Name = name;
            this.Element = element;
            this.Hp = hp;
        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int Hp { get; set; }
    }
}
