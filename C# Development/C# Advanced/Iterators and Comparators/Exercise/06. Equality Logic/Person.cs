using System;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            return result != 0 ? result : this.Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (other == null)
            {
                return false;
            }

            return this.Name == other.Name && this.Age == other.Age;
        }

        public override int GetHashCode() => this.Name.GetHashCode() + this.Age.GetHashCode();
    }
}