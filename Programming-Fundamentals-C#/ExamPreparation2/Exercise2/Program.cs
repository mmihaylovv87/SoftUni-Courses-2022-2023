using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Hero> heroes = new List<Hero>();

        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] heroInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = heroInfo[0];
            int hp = int.Parse(heroInfo[1]);
            int mp = int.Parse(heroInfo[2]);
            heroes.Add(new Hero(name, hp, mp));
        }

        while (true)
        {
            string[] command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            string action = command[0];
            if (action == "End")
            {
                foreach (var hero in heroes)
                {
                    Console.WriteLine($"{hero.Name}");
                    Console.WriteLine($"  HP: {hero.HP}");
                    Console.WriteLine($"  MP: {hero.MP}");
                }
                break;
            }
            
            string heroName = command[1];
            if (action == "CastSpell")
            {
                int neededMP = int.Parse(command[2]);
                string spellName = command[3];
                if (heroes.First(h => h.Name == heroName).MP >= neededMP)
                {
                    heroes.First(h => h.Name == heroName).MP -= neededMP;
                    Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes.First(h => h.Name == heroName).MP} MP!");
                }
                else
                    Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
            else if (action == "TakeDamage")
            {
                int damage = int.Parse(command[2]);
                string attacker = command[3];
                if (heroes.First(h => h.Name == heroName).HP - damage > 0)
                {
                    heroes.First(h => h.Name == heroName).HP -= damage;
                    Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes.First(h => h.Name == heroName).HP} HP left!");
                }
                else
                {
                    Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    heroes.Remove(heroes.First(h => h.Name == heroName));
                }
            }
            else if (action == "Recharge")
            {
                int amountRecoveredMP = int.Parse(command[2]);
                if (heroes.First(h => h.Name == heroName).MP + amountRecoveredMP > 200)
                {
                    Console.WriteLine($"{heroName} recharged for {200 - heroes.First(h => h.Name == heroName).MP} MP!");
                    heroes.First(h => h.Name == heroName).MP = 200;
                }
                else
                {
                    Console.WriteLine($"{heroName} recharged for {amountRecoveredMP} MP!");
                    heroes.First(h => h.Name == heroName).MP += amountRecoveredMP;
                }
            }
            else if (action == "Heal")
            {
                int amountRecoveredHP = int.Parse(command[2]);
                if (heroes.First(h => h.Name == heroName).HP + amountRecoveredHP > 100)
                {
                    Console.WriteLine($"{heroName} healed for {100 - heroes.First(h => h.Name == heroName).HP} HP!");
                    heroes.First(h => h.Name == heroName).HP = 100;
                }
                else
                {
                    Console.WriteLine($"{heroName} healed for {amountRecoveredHP} HP!");
                    heroes.First(h => h.Name == heroName).HP += amountRecoveredHP;
                }
            }
        }
    }
}

class Hero
{
    public Hero(string name, int hP, int mP)
    {
        this.Name = name;
        this.HP = hP;
        this.MP = mP;
    }

    public string Name { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }
}