using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            /*Tire[] tires = new Tire[4]
            {
                new Tire(2022, 5),
                new Tire(2022, 5),
                new Tire(2022, 5),
                new Tire(2022, 5),
            };
            Engine engine = new Engine(245, 3000);
            Car car = new Car("BMW", "X3", 2022, 100, 5, engine, tires);*/

            /*while (true)
            {
                Console.WriteLine("Where to go?");

                car.Drive(int.Parse(Console.ReadLine()));
                Console.WriteLine($"{car.WhoAmI()}");
            }*/
            List<Tire[]> listTires = new List<Tire[]>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command[0] == "No")
                    break;

                Tire[] tires = new Tire[command.Length / 2];
                for (int i = 1; i < command.Length; i++)
                {
                    int years = int.Parse(command[i - 1]);
                    double pressure = double.Parse(command[i]);
                    new Tire(years, pressure);
                }
                listTires.Add(tires);
            }

            List<Engine> listEngine= new List<Engine>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command[0] == "Engine")
                    break;

                int horsePower = int.Parse(command[0]);
                double cubicCapacity = double.Parse(command[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                listEngine.Add(engine);
            }


        }
    }
}