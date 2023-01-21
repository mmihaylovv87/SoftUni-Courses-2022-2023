using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (personInfo[0] == "END") 
                    break;

                Person person = new Person
                {
                    Name = personInfo[0],
                    Age = int.Parse(personInfo[1]),
                    Town = personInfo[2],
                };
                people.Add(person);
            }

            int compareIndex = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[compareIndex];

            int equalCount = 0;
            int diffrentCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                    equalCount++;
                else
                    diffrentCount++;
            }

            if (equalCount == 1)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{equalCount} {diffrentCount} {people.Count}");
        }
    }
}