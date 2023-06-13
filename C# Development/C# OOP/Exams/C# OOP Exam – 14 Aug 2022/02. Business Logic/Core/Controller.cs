using PlanetWars.Core.Contracts;
using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        private PlanetRepository planets;

        public Controller()
        {
            planets = new PlanetRepository();
        }

        public string AddUnit(string unitTypeName, string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (!new string[] { "AnonymousImpactUnit", "SpaceForces", "StormTroopers" }.Contains(unitTypeName))
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ItemNotAvailable, unitTypeName));
            }

            if (planet.Army.Any(u => u.GetType().Name == unitTypeName))
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnitAlreadyAdded, unitTypeName, planetName));
            }

            IMilitaryUnit unit = null;

            switch (unitTypeName)
            {
                case "AnonymousImpactUnit": unit = new AnonymousImpactUnit(); break;
                case "SpaceForces": unit = new SpaceForces(); break;
                case "StormTroopers": unit = new StormTroopers(); break;
            }

            planet.Spend(unit.Cost);
            planet.AddUnit(unit);
            return String.Format(OutputMessages.UnitAdded, unitTypeName, planetName);
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (planet.Weapons.Any(w => w.GetType().Name == weaponTypeName))
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.WeaponAlreadyAdded, weaponTypeName, planetName));
            }

            if (!new string[] { "BioChemicalWeapon", "NuclearWeapon", "SpaceMissiles" }.Contains(weaponTypeName))
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ItemNotAvailable, weaponTypeName));
            }

            IWeapon weapon = null;

            switch (weaponTypeName)
            {
                case "BioChemicalWeapon": weapon = new BioChemicalWeapon(destructionLevel); break;
                case "NuclearWeapon": weapon = new NuclearWeapon(destructionLevel); break;
                case "SpaceMissiles": weapon = new SpaceMissiles(destructionLevel); break;
            }

            planet.Spend(weapon.Price);
            planet.AddWeapon(weapon);
            return String.Format(OutputMessages.WeaponAdded, planetName, weaponTypeName);
        }

        public string CreatePlanet(string name, double budget)
        {
            if (planets.FindByName(name) != null)
            {
                return String.Format(OutputMessages.ExistingPlanet, name);
            }

            planets.AddItem(new Planet(name, budget));
            return String.Format(OutputMessages.NewPlanet, name);
        }

        public string ForcesReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine("***UNIVERSE PLANET MILITARY REPORT***");

            foreach (var planet in planets.Models.OrderByDescending(p => p.MilitaryPower).ThenBy(p => p.Name))
            {
                sb.AppendLine(planet.PlanetInfo());
            }

            return sb.ToString().Trim();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            IPlanet first = planets.FindByName(planetOne);
            IPlanet second = planets.FindByName(planetTwo);

            string winner = "none";
            bool firstHasNuclear = first.Weapons.Any(w => w.GetType().Name == "NuclearWeapon");
            bool secondHasNuclear = second.Weapons.Any(w => w.GetType().Name == "NuclearWeapon");

            if (first.MilitaryPower > second.MilitaryPower)
            {
                winner = "first";
            }
            else if (second.MilitaryPower > first.MilitaryPower)
            {
                winner = "second";
            }
            else // equal
            {
                if (firstHasNuclear && !secondHasNuclear)
                {
                    winner = "first";
                }
                else if (secondHasNuclear && !firstHasNuclear)
                {
                    winner = "second";
                }
            }

            string output = string.Empty;

            switch (winner)
            {
                case "first": output = WarAfterMath(first, second); break;
                case "second": output = WarAfterMath(second, first); break;
                case "none":
                    first.Spend(first.Budget / 2);
                    second.Spend(second.Budget / 2);
                    output = OutputMessages.NoWinner;
                    break;
            }

            return output;
        }

        private string WarAfterMath(IPlanet winner, IPlanet loser)
        {
            double loserCosts = loser.Army.Sum(a => a.Cost) + loser.Weapons.Sum(w => w.Price);

            winner.Spend(winner.Budget / 2);
            winner.Profit(loser.Budget / 2);
            winner.Profit(loserCosts);
            planets.RemoveItem(loser.Name);
            return String.Format(OutputMessages.WinnigTheWar, winner.Name, loser.Name);
        }
        public string SpecializeForces(string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);

            if (planet == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (!planet.Army.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.NoUnitsFound);
            }

            planet.Spend(1.25);
            planet.TrainArmy();
            return String.Format(OutputMessages.ForcesUpgraded, planetName);
        }
    }
}
