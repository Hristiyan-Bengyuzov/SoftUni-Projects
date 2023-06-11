using NavalVessels.Models.Contracts;
using NavalVessels.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Models
{
    public abstract class Vessel : IVessel
    {
        protected Vessel(string name, double mainWeaponCaliber, double speed, double armorThickness)
        {
            Name = name;
            MainWeaponCaliber = mainWeaponCaliber;
            Speed = speed;
            ArmorThickness = armorThickness;
            targets = new List<string>();
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidVesselName);
                }

                name = value;
            }
        }

        private ICaptain captain;

        public ICaptain Captain
        {
            get => captain;
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(ExceptionMessages.InvalidCaptainToVessel);
                }

                captain = value;
            }
        }

        private double armorThickness;

        public double ArmorThickness
        {
            get => armorThickness;
            set
            {
                if (value < 0)
                {
                    armorThickness = 0;
                }
                else
                {
                    armorThickness = value;
                }
            }
        }

        private double mainWeaponCaliber;

        public double MainWeaponCaliber
        {
            get { return mainWeaponCaliber; }
            protected set { mainWeaponCaliber = value; }
        }

        private double speed;

        public double Speed
        {
            get { return speed; }
            protected set { speed = value; }
        }

        private List<string> targets;

        public ICollection<string> Targets => targets.AsReadOnly();

        public void Attack(IVessel target)
        {
            if (target == null)
            {
                throw new NullReferenceException(ExceptionMessages.InvalidTarget);
            }

            target.ArmorThickness -= this.MainWeaponCaliber;
            targets.Add(target.Name);
        }

        public virtual void RepairVessel()
        {
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string targetsString = Targets.Any() ? string.Join(", ", targets) : "None";

            sb.AppendLine($"- {Name}");
            sb.AppendLine($" *Type: {GetType().Name}");
            sb.AppendLine($" *Armor thickness: {ArmorThickness}");
            sb.AppendLine($" *Main weapon caliber: {MainWeaponCaliber}");
            sb.AppendLine($" *Speed: {Speed} knots");
            sb.Append($" *Targets: " + targetsString);
            return sb.ToString().Trim();
        }
    }
}
