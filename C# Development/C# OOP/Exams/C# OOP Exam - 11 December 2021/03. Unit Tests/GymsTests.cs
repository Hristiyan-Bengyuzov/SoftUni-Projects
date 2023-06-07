using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        private Athlete athlete;
        private Gym gym;
        private string athleteName = "Gosho";
        private string gymName = "Levski";
        private int size = 3;

        [SetUp]
        public void SetUp()
        {
            athlete = new Athlete(athleteName);
            gym = new Gym(gymName, size);
        }

        [Test]
        public void Test_AthleteConstructorShouldWorkProperly()
        {
            Assert.AreEqual(athleteName, athlete.FullName);
            Assert.AreEqual(false, athlete.IsInjured);
        }

        [Test]
        public void Test_GymConstructorShouldWorkProperly()
        {
            Assert.AreEqual(gymName, gym.Name);
            Assert.AreEqual(size, gym.Capacity);
            Assert.AreEqual(0, gym.Count);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_GymConstructorShouldThrowForName(string name)
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(name, size));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-20)]
        public void Test_GymConstructorShouldThrowForSize(int size)
        {
            Assert.Throws<ArgumentException>(() => new Gym(gymName, size));
        }


        [Test]
        public void Test_AddAthleteShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            Assert.AreEqual(1, gym.Count);
        }

        [Test]
        public void Test_AddAthleteShouldThrowForFullGym()
        {
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(athlete));
        }

        [Test]
        public void Test_RemovePlayerShouldThrowForInvalidAthlete()
        {
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Pesho"));
        }

        [Test]
        public void Test_RemovePlayerShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            gym.RemoveAthlete(athleteName);
            Assert.AreEqual(0, gym.Count);
        }

        [Test]
        public void Test_InjurePLayerShouldThrowForInvalidAthlete()
        {
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Pesho"));
        }

        [Test]
        public void Test_InjurePlayerShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            var injuredAthlete = gym.InjureAthlete(athleteName);
            Assert.AreEqual(athlete, injuredAthlete);
            Assert.AreEqual(true, athlete.IsInjured);
        }

        [Test]
        public void Test_ReportShouldWorkProperly()
        {
            gym.AddAthlete(athlete);
            gym.InjureAthlete(athleteName); // this athlete will get ignored

            gym.AddAthlete(new Athlete("Pesho"));
            gym.AddAthlete(new Athlete("Penka"));
           
            string athleteNames = "Pesho, Penka";
            var expectedText = $"Active athletes at {gymName}: {athleteNames}";
            Assert.AreEqual(expectedText, gym.Report());
        }
    }
}
