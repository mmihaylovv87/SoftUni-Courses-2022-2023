using System;
using System.Collections.Generic;

namespace _06._Speed_Racing
{
    public class SpeedRacing
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsByNames = new Dictionary<string, Car>();
            
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] carsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car
                {
                    Model = carsInfo[0],
                    FuelAmount = double.Parse(carsInfo[1]),
                    FuelConsumptionPerKilometer = double.Parse(carsInfo[2])
                };
                carsByNames.Add(car.Model, car);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                    break;

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]); 

                Car car = carsByNames[carModel];
                car.Drive(amountOfKm);
            }

            foreach (var car in carsByNames.Values)
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }
    }
}