using System;
using System.Collections.Generic;
using System.Linq;

namespace SixthExercise
{
    public class StartUp
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                    break;

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int horsepower = int.Parse(tokens[3]);
                vehicles.Add(new Vehicle(type, model, color, horsepower));
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                    break;

                Vehicle vehicle = vehicles.First(v => v.Model == command);
                Console.WriteLine(vehicle);
            }
        }
    }
}