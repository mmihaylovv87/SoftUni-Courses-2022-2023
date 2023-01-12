using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> wagonsPlaces = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPeopleInWagon = 4;
            for (int i = 0; i < wagonsPlaces.Count; i++)
            {
                for (int j = wagonsPlaces[i]; j < maxPeopleInWagon; j++)
                {
                    if (peopleWaiting > 0)
                    {
                        wagonsPlaces[i]++;
                        peopleWaiting--;
                    }
                    else
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", wagonsPlaces));
                        return;
                    }
                }
            }
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", wagonsPlaces));
        }
    }
}