using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("")]
        [TestCase(null)]
        public void MakeShouldThrowAnExceptionWhenIsNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, "Supra", 6.5, 33.5));
        }

        [Test]
        public void MakeShouldWorkProperly()
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            Assert.AreEqual(car.Make, "Toyota");
        }

        [TestCase("")]
        [TestCase(null)]
        public void ModelShouldThrowAnExceptionWhenIsNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("Toyota", model, 6.5, 33.5));
        }

        [Test]
        public void ModelShouldWorkProperly()
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            Assert.AreEqual(car.Model, "Supra");
        }

        [TestCase(0)]
        [TestCase(-0.5)]
        [TestCase(-2)]
        public void FuelConsumptionShouldThrowAnExceptionWhenFuelConsumptionIsEqualOrLessThanZero(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => new Car("Toyota", "Supra", fuelConsumption, 33.5));
        }

        [Test]
        public void FuelConsumptionShouldWorkProperly()
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            Assert.AreEqual(car.FuelConsumption, 8.5);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-0.5)]
        public void FuelCapacityShouldThrowAnExceptionWhenFuelConsumptionIsEqualOrLessThanZero(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car("Toyota", "Supra", -2.5, fuelCapacity));
        }

        [Test]
        public void FuelCapacityShouldWorkProperly()
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            Assert.AreEqual(car.FuelCapacity, 33.5);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-0.5)]
        public void RefuelMethodShouldThrowAnExcprtionWhenFuelToRefuelIsEqualOrLessThanZero(double fuelToRefuel)
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }

        [Test]
        public void RefuelMethodShouldNotRefuelMoreThanCapacity()
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            car.Refuel(10);
            car.Refuel(55);
            Assert.AreEqual(car.FuelAmount, 33.5);
        }

        [Test]
        public void RefuelMethodShouldWorkProperly() 
        {
            Car car = new Car("Toyota", "Supra", 8.5, 33.5);
            car.Refuel(6.5);
            car.Refuel(13.5);
            Assert.AreEqual(car.FuelAmount, 20);
        }

        [Test]
        public void DriveMethodShouldThrowAnExceptionWhenFuelNeededIsMoreThanFuelAmount()
        {
            Car car = new Car("Toyota", "Supra", 10, 60);
            car.Refuel(40);
            Assert.Throws<InvalidOperationException>(() => car.Drive(400.1));
        }

        [Test]
        public void DriveMethodShouldSumCorrectlyFuelNeeded()
        {
            Car car = new Car("Toyota", "Supra", 10, 60);
            car.Refuel(40);
            car.Drive(200);
            Assert.AreEqual(car.FuelAmount, 20);
        }
    }
}