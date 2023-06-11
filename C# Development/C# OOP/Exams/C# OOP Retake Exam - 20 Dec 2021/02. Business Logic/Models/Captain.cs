using NavalVessels.Models.Contracts;
using NavalVessels.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Models
{
    public class Captain : ICaptain
    {
        public Captain(string fullName)
        {
            FullName = fullName;
            vessels = new List<IVessel>();
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidCaptainName);
                }

                fullName = value;
            }
        }

        private int combatExperience;

        public int CombatExperience
        {
            get { return combatExperience; }
            private set { combatExperience = value; }
        }


        private List<IVessel> vessels;

        public ICollection<IVessel> Vessels => vessels.AsReadOnly();

        public void AddVessel(IVessel vessel)
        {
            if (vessel == null)
            {
                throw new NullReferenceException(ExceptionMessages.InvalidVesselForCaptain);
            }

            vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            CombatExperience += 10;
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{FullName} has {CombatExperience} combat experience and commands {vessels.Count} vessels.");

            if (vessels.Any())
            {
                vessels.ForEach(v => sb.AppendLine(v.ToString()));
            }

            return sb.ToString().Trim();
        }
    }
}
