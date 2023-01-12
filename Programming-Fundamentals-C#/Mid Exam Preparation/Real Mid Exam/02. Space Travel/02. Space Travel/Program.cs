using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("||").ToList();
            int amountOfFuel = int.Parse(Console.ReadLine());
            int amountOfAmmunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Count; i++)
            {
                string[] commands = input[i].Split(' ');
                string command = commands[0];

                if (command == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }
                int power = int.Parse(commands[1]);

                if (command == "Travel")
                {
                    if (power <= amountOfFuel)
                    {
                        Console.WriteLine($"The spaceship travelled {power} light-years.");
                        amountOfFuel -= power;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                    continue;
                }
                else if (command == "Enemy")
                {
                    if (amountOfAmmunition >= power)
                    {
                        Console.WriteLine($"An enemy with {power} armour is defeated.");
                        amountOfAmmunition -= power;
                    }
                    else
                    {
                        if (amountOfFuel >= power * 2 )
                        {
                            Console.WriteLine($"An enemy with {power} armour is outmaneuvered.");
                            amountOfFuel -= power;
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                    continue;
                }
                else if (command == "Repair")
                {
                    Console.WriteLine($"Ammunitions added: {power * 2}.");
                    Console.WriteLine($"Fuel added: {power}.");
                    amountOfAmmunition += power * 2;
                    amountOfFuel += power;
                }
            }
        }
    }
}