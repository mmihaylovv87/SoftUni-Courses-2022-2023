using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Plantation> plantations = new List<Plantation>();

        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] tokens = Console.ReadLine().Split("<->");
            string plant = tokens[0];
            string rarity = tokens[1];

            if (!plantations.Any(p => p.Plant == plant))
            {
                Plantation plantation = new Plantation(plant, rarity);
                plantations.Add(plantation);
            }
            else
                plantations.First(p => p.Plant == plant).Rarity = rarity;
        }

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Exhibition")
            {
                Console.WriteLine("Plants for the exhibition:");
                foreach (var plantation in plantations)
                    Console.WriteLine($"- {plantation.Plant}; Rarity: {plantation.Rarity}; Rating: {plantation.Rating:f2}");
                break;
            }

            string[] tokens = command.Split(": ");
            string action = tokens[0];
            if (action == "Rate")
            {
                string plant = tokens[1].Split(" - ")[0];
                double rating = int.Parse(tokens[1].Split(" - ")[1]);
                if (plantations.Any(p => p.Plant == plant))
                    plantations.First(p => p.Plant == plant).Rating = rating;
                else
                    Console.WriteLine("error");
            }
            else if (action == "Update")
            {
                string plant = tokens[1].Split(" - ")[0];
                string newRarity = tokens[1].Split(" - ")[1];
                if (plantations.Any(p => p.Plant == plant))
                    plantations.First(p => p.Plant == plant).Rarity = newRarity;
                else
                    Console.WriteLine("error");
            }
            else if (action == "Reset")
            {
                string plant = tokens[1];
                if (plantations.Any(p => p.Plant == plant))
                    plantations.First(p => p.Plant == plant).Rating = 0.00;
                else
                    Console.WriteLine("error");
            }
        }
    }
}

class Plantation
{
    public Plantation(string plant, string rarity)
    {
        Plant = plant;
        Rarity = rarity;
    }

    public string Plant { get; set; }
    public string Rarity { get; set; }
    public double Rating { get; set; }
}