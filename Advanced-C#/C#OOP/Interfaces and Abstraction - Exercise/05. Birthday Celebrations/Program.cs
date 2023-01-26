using System;
using System.Collections.Generic;

namespace _05._Birthday_Celebrations
{
    public class Program
    {
        public static void Main()
        {
            List<ICreature> creatures = new List<ICreature>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0] == "End")
                    break;
                else if (tokens[0] == "Citizen")
                {
                    ICreature citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    creatures.Add(citizen);
                }
                else if (tokens[0] == "Pet")
                {
                    ICreature pet = new Pet(tokens[1], tokens[2]);
                    creatures.Add(pet);
                }
                else if (tokens[0] == "Robot")
                {
                    IRobot robot = new Robot(tokens[1], tokens[2]);
                }
            }

            string year = Console.ReadLine();
            foreach (var creature in creatures)
            {
                if (creature.Birthdate.EndsWith(year))
                    Console.WriteLine(creature.Birthdate);
            }
        }
    }
}