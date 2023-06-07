using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipment;
        private List<IGym> gyms;

        public Controller()
        {
            equipment = new EquipmentRepository();
            gyms = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete;
            IGym gym = gyms.FirstOrDefault(g => g.Name == gymName);

            switch (athleteType)
            {
                case "Boxer": athlete = new Boxer(athleteName, motivation, numberOfMedals); break;
                case "Weightlifter": athlete = new Weightlifter(athleteName, motivation, numberOfMedals); break;
                default: throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }

            if ((athlete.GetType() == typeof(Boxer) && gym.GetType() != typeof(BoxingGym))
                || (athlete.GetType() == typeof(Weightlifter) && gym.GetType() != typeof(WeightliftingGym)))
            {
                return OutputMessages.InappropriateGym;
            }

            gym.AddAthlete(athlete);
            return String.Format(OutputMessages.EntityAddedToGym, athleteType, gymName);
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment eqiupment;

            switch (equipmentType)
            {
                case "BoxingGloves": eqiupment = new BoxingGloves(); break;
                case "Kettlebell": eqiupment = new Kettlebell(); break;
                default: throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }

            this.equipment.Add(eqiupment);
            return String.Format(OutputMessages.SuccessfullyAdded, equipmentType);
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym;

            switch (gymType)
            {
                case "BoxingGym": gym = new BoxingGym(gymName); break;
                case "WeightliftingGym": gym = new WeightliftingGym(gymName); break;
                default: throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }

            gyms.Add(gym);
            return String.Format(OutputMessages.SuccessfullyAdded, gymType);
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gym = gyms.FirstOrDefault(g => g.Name == gymName);

            return String.Format(OutputMessages.EquipmentTotalWeight, gymName, gym.EquipmentWeight);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment equipment = this.equipment.FindByType(equipmentType);

            if (equipment == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistentEquipment, equipmentType));
            }

            IGym gym = gyms.FirstOrDefault(g => g.Name == gymName);

            gym.AddEquipment(equipment);
            this.equipment.Remove(equipment);
            return String.Format(OutputMessages.EntityAddedToGym, equipmentType, gymName);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            gyms.ForEach(g => sb.AppendLine(g.GymInfo()));
            return sb.ToString().Trim();
        }

        public string TrainAthletes(string gymName)
        {
            IGym gym = gyms.FirstOrDefault(g => g.Name == gymName);

            gym.Exercise();
            return String.Format(OutputMessages.AthleteExercise, gym.Athletes.Count);
        }
    }
}
