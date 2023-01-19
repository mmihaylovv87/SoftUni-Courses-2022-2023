using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main()
        {
            HashSet<string> carNumbers = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string number = tokens[1];
                if (direction == "IN")
                    carNumbers.Add(number);
                else if (direction == "OUT")
                    carNumbers.Remove(number);
            }
            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (string carNumber in carNumbers)
                Console.WriteLine(carNumber);
        }
    }
}