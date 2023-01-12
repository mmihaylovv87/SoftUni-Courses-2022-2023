using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBiscuitsPerDay = int.Parse(Console.ReadLine());
            int countOfTheWorkers = int.Parse(Console.ReadLine());
            int numberOfBiscuitsOfOtherFabricPerMonth = int.Parse(Console.ReadLine());

            int sumOfBiscuitsPerDay = numberOfBiscuitsPerDay * countOfTheWorkers;
            double sumOfBiscuitsPerMonth = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    sumOfBiscuitsPerMonth += Math.Floor(sumOfBiscuitsPerDay * 0.75);
                }
                else
                {
                    sumOfBiscuitsPerMonth += sumOfBiscuitsPerDay;
                }
            }
            Console.WriteLine($"You have produced {sumOfBiscuitsPerMonth} biscuits for the past month.");
            if (sumOfBiscuitsPerMonth > numberOfBiscuitsOfOtherFabricPerMonth)
            {
                Console.WriteLine($"You produce {((sumOfBiscuitsPerMonth - numberOfBiscuitsOfOtherFabricPerMonth) / numberOfBiscuitsOfOtherFabricPerMonth * 100):f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {((numberOfBiscuitsOfOtherFabricPerMonth - sumOfBiscuitsPerMonth) / numberOfBiscuitsOfOtherFabricPerMonth * 100):f2} percent less biscuits.");
            }
        }
    }
}