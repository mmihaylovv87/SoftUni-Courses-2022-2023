using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Raiding
{
    public class StartUp
    {
        public static void Main()
        {
            List<IBaseHero> heroes = new List<IBaseHero>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();
                try
                {
                    if (heroType == "Druid")
                        heroes.Add(new Druid(name));
                    else if (heroType == "Paladin")
                        heroes.Add(new Paladin(name));
                    else if (heroType == "Rogue")
                        heroes.Add(new Rogue(name));
                    else if (heroType == "Warrior")
                        heroes.Add(new Warrior(name));
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
                Console.WriteLine(hero.CastAbility());
   
            int heroesPower = heroes.Sum(h => h.Power);
            if (heroesPower >= bossPower) 
                Console.WriteLine("Victory!");
            else 
                Console.WriteLine("Defeat...");
        }
    }
}