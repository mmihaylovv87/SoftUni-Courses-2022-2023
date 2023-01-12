using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberofWagons];

            int sumPeople = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sumPeople += wagons[i];

            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
            Console.WriteLine();
            Console.WriteLine(sumPeople);
        }
    }
}