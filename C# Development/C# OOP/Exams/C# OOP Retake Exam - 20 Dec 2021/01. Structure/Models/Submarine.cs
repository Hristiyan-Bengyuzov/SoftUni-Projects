using NavalVessels.Models.Contracts;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 200)
        {
        }

        public override void RepairVessel()
        {
            if (ArmorThickness < 200)
            {
                ArmorThickness = 200;
            }
        }

        private bool submergeMode;

        public bool SubmergeMode
        {
            get { return submergeMode; }
            private set { submergeMode = value; }
        }

        public void ToggleSubmergeMode()
        {
            SubmergeMode = !SubmergeMode;

            if (SubmergeMode)
            {
                MainWeaponCaliber += 40;
                Speed -= 4;
            }
            else
            {
                MainWeaponCaliber -= 40;
                Speed += 4;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string mode = SubmergeMode ? "ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Submerge mode: {mode}");

            return sb.ToString().Trim();
        }
    }
}
