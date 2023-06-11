using NavalVessels.Models.Contracts;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 300)
        {
        }

        private bool sonarMode;

        public bool SonarMode
        {
            get { return sonarMode; }
            private set { sonarMode = value; }
        }

        public override void RepairVessel()
        {
            if (ArmorThickness < 300)
            {
                ArmorThickness = 300;
            }
        }

        public void ToggleSonarMode()
        {
            SonarMode = !SonarMode;

            if (SonarMode)
            {
                MainWeaponCaliber += 40;
                Speed -= 5;
            }
            else
            {
                MainWeaponCaliber -= 40;
                Speed += 5;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string mode = SonarMode ? "ON" : "OFF";

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Sonar mode: {mode}"); ;

            return sb.ToString().Trim();
        }
    }
}
