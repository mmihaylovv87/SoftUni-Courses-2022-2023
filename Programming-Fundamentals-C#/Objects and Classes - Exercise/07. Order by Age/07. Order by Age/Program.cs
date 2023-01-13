﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();
            List<Person> personsList = new List<Person>();

            while (commands[0] != "End")
            {
                var persons = new Person(commands[0], int.Parse(commands[1]), int.Parse(commands[2]));
                personsList.Add(persons);
                commands = Console.ReadLine().Split();
            }

            personsList.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));

            // foreach (var person in personsList.OrderBy(person => person.Age))
            // {
            //     Console.WriteLine(person);
            // }
        }
    }

    class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
    }
}