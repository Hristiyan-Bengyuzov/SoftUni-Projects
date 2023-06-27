using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FootballTeam.Tests
{
    public class Tests
    {
        private FootballPlayer player;
        private string playerName = "Berbatov";
        private int playerNumber = 10;
        private string position = "Forward";
        private FootballTeam team;
        private string teamName = "Levski";
        private int capacity = 15;

        [SetUp]
        public void Setup()
        {
            player = new FootballPlayer(playerName, playerNumber, position);
            team = new FootballTeam(teamName, capacity);
        }

        [Test]
        public void Test_PlayerConstructorShouldWorkProperly()
        {
            Assert.AreEqual(playerName, player.Name);
            Assert.AreEqual(playerNumber, player.PlayerNumber);
            Assert.AreEqual(position, player.Position);
            Assert.AreEqual(0, player.ScoredGoals);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Test_PlayerNameShouldThrow(string name)
        {
            Assert.Throws<ArgumentException>(() => new FootballPlayer(name, playerNumber, position));
        }

        [Test]
        [TestCase(0)]
        [TestCase(22)]
        [TestCase(-20)]
        [TestCase(30)]
        public void Test_PlayerNumberShouldThrow(int number)
        {
            Assert.Throws<ArgumentException>(() => new FootballPlayer(playerName, number, position));
        }

        [Test]
        [TestCase("Invalid")]
        [TestCase("Idk man")]
        [TestCase("Lmao")]
        public void Test_PlayerPositionShouldThrow(string position)
        {
            Assert.Throws<ArgumentException>(() => new FootballPlayer(playerName, playerNumber, position));
        }

        [Test]
        public void Test_ScoreGoalShouldWork()
        {
            player.Score();
            Assert.AreEqual(1, player.ScoredGoals);
        }

        [Test]
        public void Test_TeamConstructorShouldWorkProperly()
        {
            Assert.AreEqual(teamName, team.Name);
            Assert.AreEqual(capacity, team.Capacity);
            CollectionAssert.AreEqual(new List<FootballPlayer>(), team.Players);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Test_TeamNameShouldThrow(string name)
        {
            Assert.Throws<ArgumentException>(() => new FootballTeam(name, capacity));
        }

        [Test]
        [TestCase(14)]
        [TestCase(0)]
        [TestCase(-20)]
        public void Test_TeamCapacityShouldThrow(int capacity)
        {
            Assert.Throws<ArgumentException>(() => new FootballTeam(teamName, capacity));
        }

        [Test]
        public void Test_AddPlayerShouldWork()
        {
            Assert.AreEqual($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}", team.AddNewPlayer(player));
            Assert.AreEqual(1, team.Players.Count);
        }

        [Test]
        public void Test_AddPlayersShouldSayNoMorePlayers()
        {
            for (int i = 0; i < team.Capacity; i++)
            {
                team.AddNewPlayer(player);
            }

            Assert.AreEqual("No more positions available!", team.AddNewPlayer(player));
        }

        [Test]
        public void Test_PickPlayerShouldWorkProperly()
        {
            team.AddNewPlayer(player);
            Assert.AreEqual(player, team.PickPlayer(playerName));
        }

        [Test]
        public void Test_PickPlayerShouldReturnNull()
        {
            team.AddNewPlayer(player);
            Assert.AreEqual(null, team.PickPlayer("Gosho"));
        }

        [Test]
        public void Test_PlayerScoreShouldWorkProperly()
        {
            team.AddNewPlayer(player);
            Assert.AreEqual($"{playerName} scored and now has {1} for this season!", team.PlayerScore(playerNumber));
        }
    }
}