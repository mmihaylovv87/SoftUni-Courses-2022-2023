using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> heroList = new Dictionary<string, List<string>>();
        while (true)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string action = command[0];
            if (action == "End")
            {
                Console.WriteLine("Heroes:");
                foreach (var hero in heroList)
                    Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
                break;
            }
            string heroName = command[1];
            if (action == "Enroll")
            {
                if (heroList.ContainsKey(heroName))
                    Console.WriteLine($"{heroName} is already enrolled.");
                else
                    heroList.Add(heroName, new List<string>());
            }
            else if (action == "Learn")
            {
                string spellName = command[2];
                if (heroList.ContainsKey(heroName))
                {
                    if (heroList[heroName].Contains(spellName))
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                    else
                        heroList[heroName].Add(spellName);
                }
                else
                    Console.WriteLine($"{heroName} doesn't exist.");
            }
            else if (action == "Unlearn")
            {
                string spellName = command[2];
                if (heroList.ContainsKey(heroName))
                {
                    if (heroList[heroName].Contains(spellName))
                        heroList[heroName].Remove(spellName);
                    else
                        Console.WriteLine($"{heroName} doesn't know {spellName}.");
                }
                else
                    Console.WriteLine($"{heroName} doesn't exist.");
            }
        }
    }
}