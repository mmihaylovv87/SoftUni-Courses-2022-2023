using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFood = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (inputFood)
            {
                case "coffee":
                    sum = count * 1.50;
                    break;
                case "water":
                    sum = count * 1.00;
                    break;
                case "coke":
                    sum = count * 1.40;
                    break;
                case "snacks":
                    sum = count * 2.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}