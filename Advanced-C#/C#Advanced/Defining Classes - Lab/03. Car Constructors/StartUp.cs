using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car("BMW", "X3", 2022, 100, 5);

            while (true)
            {
                Console.WriteLine("Where to go?");

                car.Drive(int.Parse(Console.ReadLine()));
                Console.WriteLine($"{car.WhoAmI()}");
            }
        }
    }
}