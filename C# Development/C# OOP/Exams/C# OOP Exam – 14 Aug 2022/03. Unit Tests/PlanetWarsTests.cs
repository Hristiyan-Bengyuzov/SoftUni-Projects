using NUnit.Framework;
using System;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            private Planet planet;
            private Weapon weapon;
            private string planetName = "Earth";
            private double budget = 100;
            private string weaponName = "Shotgun";
            private double weaponPrice = 50;
            private int destructionLevel = 6;

            [SetUp]
            public void SetUp()
            {
                planet = new Planet(planetName, budget);
                weapon = new Weapon(weaponName, weaponPrice, destructionLevel);
            }

            [Test]
            public void Test_PlanetConstructorShouldWorkProperly()
            {
                Assert.AreEqual(planetName, planet.Name);
                Assert.AreEqual(budget, planet.Budget);
                Assert.AreEqual(0, planet.Weapons.Count);
                Assert.AreEqual(0, planet.MilitaryPowerRatio);
            }

            [Test]
            [TestCase(null, 100)]
            [TestCase("", 100)]
            [TestCase("Earth", -1)]
            [TestCase("Earth", -20)]
            public void Test_PlanetConstructorShouldThrowForInvalidInput(string name, int budget)
            {
                Assert.Throws<ArgumentException>(() => new Planet(name, budget));
            }

            [Test]
            public void Test_ProfitWorksProperly()
            {
                planet.Profit(50);
                Assert.AreEqual(budget + 50, planet.Budget);
            }

            [Test]
            public void Test_SpendShouldThrow()
            {
                Assert.Throws<InvalidOperationException>(() => planet.SpendFunds(101));
            }

            [Test]
            public void Test_SpendShouldWorkProperly()
            {
                planet.SpendFunds(99);
                Assert.AreEqual(budget - 99, planet.Budget);
            }

            [Test]
            public void Test_AddWeaponShouldWorkProperly()
            {
                planet.AddWeapon(weapon);
                Assert.AreEqual(1, planet.Weapons.Count);
                Assert.AreEqual(6, planet.MilitaryPowerRatio);
            }

            [Test]
            public void Test_AddWeaponShouldThrow()
            {
                planet.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => planet.AddWeapon(weapon));
            }

            [Test]
            public void Test_RemoveShouldWorkProperly()
            {
                planet.AddWeapon(weapon);
                planet.RemoveWeapon(weaponName);
                Assert.AreEqual(0, planet.Weapons.Count);
                Assert.AreEqual(0, planet.MilitaryPowerRatio);
            }

            [Test]
            public void Test_UpgradeShouldThrow()
            {
                Assert.Throws<InvalidOperationException>(() => planet.UpgradeWeapon(weaponName));
            }

            [Test]
            public void Test_UpgradeWeaponWorksProperly()
            {
                planet.AddWeapon(weapon);
                planet.UpgradeWeapon(weaponName);
                Assert.AreEqual(destructionLevel + 1, weapon.DestructionLevel);
            }

            [Test]
            public void Test_DestructOpponentThrowsForEqualPower()
            {
                planet.AddWeapon(weapon);
                Planet opponent = new Planet("Mars", 150);
                opponent.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => planet.DestructOpponent(opponent));
            }

            [Test]
            public void Test_DestructOpponentThrowsForStrongerOpponent()
            {
                Planet opponent = new Planet("Mars", 150);
                opponent.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => planet.DestructOpponent(opponent));
            }

            [Test]
            public void Test_DestructOpponentShouldWorkProperly()
            {
                planet.AddWeapon(weapon);
                Planet opponent = new Planet("Mars", 150);
                opponent.AddWeapon(new Weapon("Glock", 20, 3));
                Assert.AreEqual($"{opponent.Name} is destructed!", planet.DestructOpponent(opponent));
            }

            [Test]
            public void Test_WeaponConstructorShouldWorkProperly()
            {
                Assert.AreEqual(weaponName, weapon.Name);
                Assert.AreEqual(weaponPrice, weapon.Price);
                Assert.AreEqual(destructionLevel, weapon.DestructionLevel);
                Assert.AreEqual(false, weapon.IsNuclear);
            }

            [Test]
            [TestCase(-1)]
            [TestCase(-100)]
            public void Test_WeaponConstructorShouldThrowForInvalidPrice(double price)
            {
                Assert.Throws<ArgumentException>(() => new Weapon("AK-47", price, 5));
            }

            [Test]
            [TestCase(10)]
            [TestCase(30)]
            public void Test_IsNuclearWorksProperly(int destructionLevel)
            {
                Weapon weapon = new Weapon("Bazooka", 200, destructionLevel);
                Assert.AreEqual(true, weapon.IsNuclear);
            }
        }
    }
}
