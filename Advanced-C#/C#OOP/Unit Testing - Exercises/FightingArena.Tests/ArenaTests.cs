using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldInitializeAllvalues()
        {
            //Arrange && Act
            Arena arena = new Arena();

            //Assert
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void EnrollMethodShouldAddWarriorIfDoesNotExist()
        {
            //Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Mihail", 50, 80);
            Warrior warrior2 = new Warrior("Viktor", 150, 280);
            Warrior warrior3 = new Warrior("Stoyan", 350, 480);

            //Act
            arena.Enroll(warrior);
            arena.Enroll(warrior2);
            arena.Enroll(warrior3);

            //Assert
            Assert.AreEqual(3, arena.Count);

            bool warriorExist = arena.Warriors.Contains(warrior);
            bool warrior2Exist = arena.Warriors.Contains(warrior2);
            bool warrior3Exist = arena.Warriors.Contains(warrior3);

            Assert.True(warriorExist);
            Assert.True(warrior2Exist);
            Assert.True(warrior3Exist);
        }

        [Test]
        public void EnrollMethodShouldThrowExceptionForDuplicateWarrior()
        {
            //Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Mihail", 50, 80);

            //Act
            arena.Enroll(warrior);

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void FightMethodShouldThrowExceptionForInvalidWarriors()
        {
            //Arrange
            Arena arena = new Arena();

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Mihail", "Viktor"));
        }

        [Test]
        public void FightMethodShouldThrowExceptionForInvalidAttacker()
        {
            //Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Stoyan", 40, 70);

            arena.Enroll(warrior);

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Mihail", "Stoyan"));
        }

        [Test]
        public void FightMethodShouldThrowExceptionForInvalidDefender()
        {
            //Arrange
            Arena arena = new Arena();
            Warrior warrior = new Warrior("Kiro", 40, 70);

            arena.Enroll(warrior);

            //Assert
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Kiro", "Viktor"));
        }

        [Test]
        public void FightShouldReduceHP()
        {
            //Arrange
            Arena arena = new Arena();

            Warrior attacker = new Warrior("Stoyan", 100, 50);
            Warrior defender = new Warrior("Kiro", 50, 100);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            //Act
            arena.Fight("Stoyan", "Kiro");

            //Assert
            Warrior warriorAttacker = arena.Warriors.FirstOrDefault(x => x.Name == "Stoyan");
            Warrior warriorDefender = arena.Warriors.FirstOrDefault(x => x.Name == "Kiro");

            Assert.AreEqual(0, warriorAttacker.HP);
            Assert.AreEqual(0, warriorDefender.HP);
        }
    }
}
