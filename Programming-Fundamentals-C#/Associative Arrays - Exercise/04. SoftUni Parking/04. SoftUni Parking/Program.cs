using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfcommands = int.Parse(Console.ReadLine());
            string[] register = new string[countOfcommands];
            Dictionary<string, string> registers = new Dictionary<string, string>();

            for (int i = 0; i < countOfcommands; i++)
            {
                register = Console.ReadLine().Split(' ');
                string registered = register[0];
                string name = register[1];

                if (!registers.ContainsKey(name))
                {
                    if (registered == "register")
                    { 
                        string numberOfCar = register[2];
                        Console.WriteLine($"{name} registered {numberOfCar} successfully");
                        registers.Add(name, numberOfCar);
                    }
                    else if (registered == "unregister")
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
                else
                {
                    if (registered == "register")
                    {
                        string numberOfCar = register[2];
                        Console.WriteLine($"ERROR: already registered with plate number {numberOfCar}");
                    }
                    else if (registered == "unregister")
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        registers.Remove(name);
                    }
                }
            }

            foreach (var item in registers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}