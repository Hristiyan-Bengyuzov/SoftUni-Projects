using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public abstract class Planet : IPlanet
    {
        protected Planet(string name, double budget)
        {
            Name = name;
            Budget = budget;
            units = new UnitRepository();
            weapons = new WeaponRepository();
        }

        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }

                name = value;
            }
        }

        private double budget;
        public double Budget
        {
            get { return budget; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);
                }

                budget = value;
            }
        }

        public double MilitaryPower
        {
            get { return CalculateMilitaryPower(); }
        }

        private UnitRepository units;
        public IReadOnlyCollection<IMilitaryUnit> Army => units.Models;

        private WeaponRepository weapons;
        public IReadOnlyCollection<IWeapon> Weapons => weapons.Models;

        public void AddUnit(IMilitaryUnit unit)
        {
            units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.AddItem(weapon);
        }

        public string PlanetInfo()
        {
            var sb = new StringBuilder();
            string unitsString = Army.Any() ? string.Join(", ", Army.Select(a => a.GetType().Name)) : "No units";
            string weaponsString = Weapons.Any() ? string.Join(", ", Weapons.Select(w => w.GetType().Name)) : "No weapons";
            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            sb.AppendLine($"--Forces: {unitsString}");
            sb.AppendLine($"--Combat equipment: {weaponsString}");
            sb.AppendLine($"--Military Power: {MilitaryPower}");
            return sb.ToString().Trim();
        }

        public void Profit(double amount)
        {
            Budget += amount;
        }

        public void Spend(double amount)
        {
            if (Budget < amount)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }

            Budget -= amount;
        }

        public void TrainArmy()
        {
            foreach (var unit in Army)
            {
                unit.IncreaseEndurance();
            }
        }

        private double CalculateMilitaryPower()
        {
            double totalAmount = Army.Sum(a => a.EnduranceLevel) + Weapons.Sum(w => w.DestructionLevel);

            if (units.FindByName("AnonymousImpactUnit") != null)
            {
                totalAmount *= 1.3;
            }

            if (weapons.FindByName("NuclearWeapon") != null)
            {
                totalAmount *= 1.45;
            }

            return Math.Round(totalAmount, 3);
        }
    }
}
