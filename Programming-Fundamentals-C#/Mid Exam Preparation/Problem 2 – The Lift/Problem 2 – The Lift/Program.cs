using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] placesOfWagons = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < placesOfWagons.Length; i++)
            {
                for (int j = placesOfWagons[i]; j <= 3; j++)
                {
                    peopleWaiting--;
                    placesOfWagons[i]++;
                    if (peopleWaiting == 0)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", placesOfWagons));
                        return;
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", placesOfWagons));
        }
    }
}