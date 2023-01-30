using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Mihail", 50, 70)]
        [TestCase("Niki", 67, 20)]
        [TestCase("Viktor", 1, 0)]
        public void ConstructorShouldSetEverythingIfDataIsValid(string name, int damage, int health)
        {
            //Arrange && Act
            Warrior warrior = new Warrior(name, damage, health);

            //Assert
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(health, warrior.HP);
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void ConstructorShouldThrowArgumentExceptionForInvalidName(string name)
        {
            //Arrange && Assert
            Assert.Throws<ArgumentException>(() => new Warrior(name, 40, 50));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-54)]
        public void ConstructorShouldThrowArgumentExceptionForInvalidDamage(int damage)
        {
            //Arrange && Assert
            Assert.Throws<ArgumentException>(() => new Warrior("Mihail", damage, 50));
        }

        [TestCase(-1)]
        [TestCase(-54)]
        public void ConstructorShouldThrowArgumentExceptionForInvalidHealth(int health)
        {
            //Arrange && Assert
            Assert.Throws<ArgumentException>(() => new Warrior("Mihail", 60, health));
        }

        [TestCase("Mihail", 50, 20, "Viktor", 50, 40)]
        [TestCase("Mihail", 50, 30, "Viktor", 50, 40)]
        [TestCase("Mihail", 50, 50, "Viktor", 50, 30)]
        [TestCase("Mihail", 50, 50, "Viktor", 50, 20)]
        public void AttackMethodShouldThrowExceptionWhenHPIsBelowOrEqual30(
            string name, int damage, int health,
            string enemyName, int enemyDamage, int enemyHealth)
        {
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHealth);

            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior));
        }

        
        [TestCase("Mihail", 50, 50, "Viktor", 90, 40)]
        public void AttackMethodShouldThrowExceptionWhenOurHPIsBelowEnemyDamage(
            string name, int damage, int health,
            string enemyName, int enemyDamage, int enemyHealth)
        {
            //Arrange
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHealth);

            //Act && Assert
            Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior));
        }

        [TestCase("Mihail", 50, 100, 50, "Viktor", 50, 100, 50)]
        [TestCase("Mihail", 100, 100, 50, "Viktor", 50, 100, 0)]
        [TestCase("Mihail", 120, 100, 50, "Viktor", 50, 100, 0)]
        public void AttackMethodShouldReduveHPForWarriorAndEnemyWarrior(
            string name, int damage, int health, int myResultHP,
            string enemyName, int enemyDamage, int enemyHealth, int enemyResultHP)
        {
            //Arrange
            Warrior myWarrior = new Warrior(name, damage, health);
            Warrior enemyWarrior = new Warrior(enemyName, enemyDamage, enemyHealth);

            //Act
            myWarrior.Attack(enemyWarrior);

            //Assert
            Assert.AreEqual(myResultHP, myWarrior.HP);
            Assert.AreEqual(enemyResultHP, enemyWarrior.HP);
        }
    }
}