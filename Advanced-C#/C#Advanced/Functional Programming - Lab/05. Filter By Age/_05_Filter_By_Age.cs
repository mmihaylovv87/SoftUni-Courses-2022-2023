using System;
using System.Collections.Generic;
using System.Linq;
class _05_Filter_By_Age
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split(", ");
            string name = input[0];
            int age = int.Parse(input[1]);
            people.Add(new Person(name, age));
        }

        string filterInput = Console.ReadLine();
        int ageFilter = int.Parse(Console.ReadLine());
        Func<Person, int, bool> filter = CetFilter(filterInput);
        people = people.Where(p => filter(p, ageFilter)).ToList();

        string formatFilter = Console.ReadLine();
        Action<Person> printer = GetPrinter(formatFilter);
        people.ForEach(printer);
    }

    private static Func<Person, int, bool> CetFilter(string filterInput)
    {
        switch (filterInput)
        {
            case "older":
                return (p, ageFilter) => p.Age >= ageFilter;
            case "younger":
                return (p, ageFilter) => p.Age < ageFilter;
            default:
                return null;
        }
    }

    private static Action<Person> GetPrinter(string formatInput)
    {
        switch (formatInput)
        {
            case "name":
                return p => Console.WriteLine(p.Name);
            case "age":
                return p => Console.WriteLine(p.Age);
            case "name age":
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            default:
                return null;
        }
    }
}

class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}