using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        protected Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            equipment = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }

        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }

                name = value;
            }
        }

        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        public double EquipmentWeight => equipment.Sum(e => e.Weight);

        private List<IEquipment> equipment;
        public ICollection<IEquipment> Equipment => equipment.AsReadOnly();

        private List<IAthlete> athletes;
        public ICollection<IAthlete> Athletes => athletes.AsReadOnly();

        public void AddAthlete(IAthlete athlete)
        {
            if (athletes.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }

            athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }

        public void Exercise()
        {
            athletes.ForEach(a => a.Exercise());
        }

        public string GymInfo()
        {
            var sb = new StringBuilder();
            string athleteString = athletes.Any() ? string.Join(", ", athletes.Select(a => a.FullName)) : "No athletes";
            sb.AppendLine($"{Name} is a {GetType().Name}:");
            sb.AppendLine($"Athletes: {athleteString}");
            sb.AppendLine($"Equipment total count: {equipment.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams");
            return sb.ToString().Trim();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletes.Remove(athlete);
        }
    }
}
