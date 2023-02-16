using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members
        {
            get => this.members;
            set => this.members = value;
        }

        public void AddMember(Person member) => this.Members.Add(member);

        public Person GetOldestMember() => this.Members.OrderByDescending(x => x.Age).First();
    }
}
