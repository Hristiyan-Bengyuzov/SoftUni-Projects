﻿namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage) => this.Salary += this.Age > 30 ? this.Salary * percentage / 100 : this.Salary * percentage / 200;
        public override string ToString() => $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
    }
}
