namespace BorderControl
{
    public class Citizen : Identifiable
    {
        public Citizen(string name, int age, string id) : base(id)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}
