using NavalVessels.Core.Contracts;
using NavalVessels.Models;
using NavalVessels.Models.Contracts;
using NavalVessels.Repositories;
using NavalVessels.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Core
{
    public class Controller : IController
    {
        private VesselRepository vessels;
        private List<ICaptain> captains;

        public Controller()
        {
            vessels = new VesselRepository();
            captains = new List<ICaptain>();
        }

        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            ICaptain captain = captains.FirstOrDefault(c => c.FullName == selectedCaptainName);
            IVessel vessel = vessels.FindByName(selectedVesselName);

            if (captain == null)
            {
                return String.Format(OutputMessages.CaptainNotFound, selectedCaptainName);
            }

            if (vessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, selectedVesselName);
            }

            if (vessel.Captain != null)
            {
                return String.Format(OutputMessages.VesselOccupied, selectedVesselName);
            }

            captain.AddVessel(vessel);
            vessel.Captain = captain;
            return String.Format(OutputMessages.SuccessfullyAssignCaptain, selectedCaptainName, selectedVesselName);
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            IVessel attacker = vessels.FindByName(attackingVesselName);
            IVessel defender = vessels.FindByName(defendingVesselName);

            if (attacker == null)
            {
                return String.Format(OutputMessages.VesselNotFound, attackingVesselName);
            }

            if (defender == null)
            {
                return String.Format(OutputMessages.VesselNotFound, defendingVesselName);
            }

            if (attacker.ArmorThickness == 0)
            {
                return String.Format(OutputMessages.AttackVesselArmorThicknessZero, attackingVesselName);
            }

            if (defender.ArmorThickness == 0)
            {
                return String.Format(OutputMessages.AttackVesselArmorThicknessZero, defendingVesselName);
            }

            attacker.Attack(defender);
            attacker.Captain.IncreaseCombatExperience();
            defender.Captain.IncreaseCombatExperience();
            return String.Format(OutputMessages.SuccessfullyAttackVessel, defendingVesselName, attackingVesselName, defender.ArmorThickness);
        }

        public string CaptainReport(string captainFullName)
        {
            return captains.FirstOrDefault(c => c.FullName == captainFullName).Report();
        }

        public string HireCaptain(string fullName)
        {
            ICaptain captain = captains.FirstOrDefault(c => c.FullName == fullName);

            if (captain != null)
            {
                return String.Format(OutputMessages.CaptainIsAlreadyHired, fullName);
            }

            captains.Add(new Captain(fullName));
            return String.Format(OutputMessages.SuccessfullyAddedCaptain, fullName);
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            if (vessels.FindByName(name) != null)
            {
                return String.Format(OutputMessages.VesselIsAlreadyManufactured, vesselType, name);
            }

            IVessel vessel;

            switch (vesselType)
            {
                case "Submarine": vessel = new Submarine(name, mainWeaponCaliber, speed); break;
                case "Battleship": vessel = new Battleship(name, mainWeaponCaliber, speed); break;
                default: return OutputMessages.InvalidVesselType;
            }

            vessels.Add(vessel);
            return String.Format(OutputMessages.SuccessfullyCreateVessel, vesselType, name, mainWeaponCaliber, speed);
        }

        public string ServiceVessel(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            if (vessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, vesselName);
            }

            vessel.RepairVessel();
            return String.Format(OutputMessages.SuccessfullyRepairVessel, vesselName);
        }

        public string ToggleSpecialMode(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            if (vessel == null)
            {
                return String.Format(OutputMessages.VesselNotFound, vesselName);
            }

            if (vessel is Battleship ship)
            {
                ship.ToggleSonarMode();
                return String.Format(OutputMessages.ToggleBattleshipSonarMode, vesselName);
            }

            // if not battleship then submarine
            ((Submarine)vessel).ToggleSubmergeMode();
            return String.Format(OutputMessages.ToggleSubmarineSubmergeMode, vesselName);
        }

        public string VesselReport(string vesselName)
        {
            return vessels.FindByName(vesselName).ToString();
        }
    }
}
