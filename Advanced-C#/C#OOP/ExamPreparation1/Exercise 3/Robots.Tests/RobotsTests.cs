namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RobotsTests
    {
        [Test]
        public void ContructorShouldSetCapacity()
        {
            RobotManager robots = new RobotManager(2);
            Assert.AreEqual(2, robots.Capacity);
        }

        [Test]
        public void ConstructorShouldThrowAnExceptionForNegativeCapacity()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-3));
        }

        [Test]
        public void EmptyRobotMandagerShouldHaveCountOFZero()
        {
            RobotManager robots = new RobotManager(100);
            Assert.AreEqual(0, robots.Count);
        }

        [Test]
        public void CountShouldSetRroperly()
        {
            RobotManager robots = new RobotManager(100);
            robots.Add(new Robot("r1", 100));
            robots.Add(new Robot("r2", 300));
            robots.Add(new Robot("r3", 200));
            Assert.AreEqual(3, robots.Count);
        }

        [Test]
        public void AddMethodShouldThrowAnExceptionWhenAddedRobotWithTheSameName()
        {
            RobotManager robots = new RobotManager(5);
            robots.Add(new Robot("r1", 1000));
            Assert.Throws<InvalidOperationException>(() => robots.Add(new Robot("r1", 50)));
        }

        [Test]
        public void AddMethodShouldThrowAnExceptionWhenCapacityIsReached()
        {
            RobotManager robots = new RobotManager(2);
            robots.Add(new Robot("r1", 100));
            robots.Add(new Robot("r2", 200));
            Assert.Throws<InvalidOperationException>(() => robots.Add(new Robot("r3", 800)));
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWhenRemovedRobotsDoesNotExist()
        {
            RobotManager robots = new RobotManager(4);
            robots.Add(new Robot("r2", 100));
            Assert.Throws<InvalidOperationException>(() => robots.Remove("r4"));
        }

        [Test]
        public void RemoveMethodShouldWorkProperly()
        {
            RobotManager robots = new RobotManager(4);
            robots.Add(new Robot("r2", 100));
            robots.Add(new Robot("r1", 200));
            robots.Remove("r1");
            Assert.AreEqual(1, robots.Count);
        }

        [Test]
        public void WorkMethodShouldThrowExceptionWhenRobotNameDoesNotExist()
        {
            RobotManager robots = new RobotManager(5);
            robots.Add(new Robot("r1", 1000));
            robots.Add(new Robot("r2", 900));
            Assert.Throws<InvalidOperationException>(() => robots.Work("r3", "..", 1000));
        }

        [Test]
        public void WorkMethodShouldThrowExceptionWhenBatteryIsNotEnough()
        {
            RobotManager robots = new RobotManager(5);
            robots.Add(new Robot("r1", 1000));
            robots.Add(new Robot("r2", 900));
            Assert.Throws<InvalidOperationException>(() => robots.Work("r2", "..", 1000));
        }

        [Test]
        public void WorkMethodShouldWorkProperly() 
        {
            RobotManager robots = new RobotManager(5);
            Robot robot = new Robot("r1", 1000);
            robots.Add(robot);
            robots.Work("r1", "...", 700);
            Assert.AreEqual(robot.Battery, 300);
        }

        [Test]
        public void ChargeMethodShouldWorkProperly()
        {
            RobotManager robots = new RobotManager(5);
            Robot robot = new Robot("r1", 1000);
            robots.Add(robot);
            robots.Work("r1", "...", 700);
            robots.Charge("r1");
            Assert.AreEqual(robot.Battery, 1000);
        }

        [Test]
        public void ChargeMethodShouldThrowAnExceptionWhenRobotNameDoesNotExist()
        {
            RobotManager robots = new RobotManager(5);
            robots.Add(new Robot("r1", 1000));
            Assert.Throws<InvalidOperationException>(() => robots.Charge("r2"));
        }
    }
}
