using System;
using System.Linq;

namespace BirthdayCelebrations
{
    public abstract class Alive
    {
        protected Alive(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public string Birthdate { get; private set; }
        public string Year { get => this.Birthdate.Split('/', StringSplitOptions.RemoveEmptyEntries).Last(); }
    }
}
