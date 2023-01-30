using ExtendedDatabase;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddRangeMethodShouldThrowAnExceptionWhenLengthAreAbove16()
        { 
            Assert.Throws<ArgumentException>(() => new ExtendedDatabase.ExtendedDatabase(new Person[17]));
        }

        [Test]
        public void CountShouldSetCorrectly()
        {
            Person[] people = new Person[16];
            people[0] = new Person(8978976976897, "gosho");
            people[1] = new Person(9786987698769, "pesho");
            people[2] = new Person(9080398028499, "misho");
            ExtendedDatabase.ExtendedDatabase extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            Assert.AreEqual(extendedDatabase.Count, 3);
        }

        [Test]
        public void AddMethodShouldThrowAnExceptionWhenTheUsernameIsRepeated()
        {
            Person[] people = new Person[16];
            people[0] = new Person(8978976976897, "gosho");
            people[1] = new Person(9786987698769, "pesho");
            people[2] = new Person(9080398028499, "misho");
            people[3] = new Person(8972269768976, "koko");
            people[4] = new Person(9743287698769, "presko");
            people[5] = new Person(9879378492785, "alex");
            people[6] = new Person(8978009768976, "titi");
            people[7] = new Person(2286987698769, "eva");
            people[8] = new Person(8877665500999, "niki");
            people[9] = new Person(8933334412342, "geri");
            people[10] = new Person(9786987698760, "boyan");
            people[11] = new Person(8009809809809, "simona");
            people[12] = new Person(8978976976976, "gabi");
            people[13] = new Person(9744987698769, "desi");
            people[14] = new Person(0099009900990, "gabi");
            people[15] = new Person(7772277444477, "martin");
            Assert.Throws<InvalidOperationException>(() => new ExtendedDatabase.ExtendedDatabase(people));
        }

        [Test]
        public void AddMethodShouldThrowAnExceptionWhenTheIdIsRepeated()
        {
            Person[] people = new Person[16];
            people[0] = new Person(8978976976897, "gosho");
            people[1] = new Person(7772277444477, "julia");
            people[2] = new Person(7772277444477, "martin");
            Assert.Throws<InvalidOperationException>(() => new ExtendedDatabase.ExtendedDatabase(people));
        }

        [Test]
        public void RemoveMethodShouldThrowAnExceptionWhenCountIsZero()
        {
            Person[] people = new Person[16];
            people[0] = new Person(8978976976897, "gosho");
            peop

            ExtendedDatabase.ExtendedDatabase extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            extendedDatabase.Remove();

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Remove());
        }
    }
}