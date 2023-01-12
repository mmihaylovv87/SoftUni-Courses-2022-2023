using System;
using System.Collections.Generic;
using System.Linq;

namespace SeventhExercise
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                    break;

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string iD = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, iD, age);
                people.Add(person);
            }

            foreach (var person in people.OrderBy(p => p.Age))
                Console.WriteLine(person);
        }
    }
}