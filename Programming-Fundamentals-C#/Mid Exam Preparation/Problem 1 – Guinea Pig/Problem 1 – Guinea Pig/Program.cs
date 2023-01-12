using System;

namespace Problem_1___Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantity = double.Parse(Console.ReadLine()) * 1000;
            double hayQuantity = double.Parse(Console.ReadLine()) * 1000;
            double coverQuantity = double.Parse(Console.ReadLine()) * 1000;
            double guineaWeight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodQuantity -= 300;
                if (i % 2 == 0)
                {
                    hayQuantity -= foodQuantity * 0.05;
                }
                if (i % 3 == 0)
                {
                    coverQuantity -= guineaWeight / 3;
                }
                if (foodQuantity <= 0 || hayQuantity <= 0 || coverQuantity <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }
            if (foodQuantity > 0 && hayQuantity > 0 && coverQuantity > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQuantity / 1000:f2}, Hay: {hayQuantity / 1000:f2}, Cover: {coverQuantity / 1000:f2}.");
            }
        }
    }
}