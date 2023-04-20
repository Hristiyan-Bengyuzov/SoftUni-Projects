namespace BirthdayCelebrations
{
    public class Citizen : Alive, IIdentifiable
    {
        public Citizen(string name, int age, string id, string birthdate) : base(name, birthdate)
        {
            this.Age = age;
            this.Id = id;
        }

        public int Age { get; private set; }
        public string Id { get; private set; }
    }
}
