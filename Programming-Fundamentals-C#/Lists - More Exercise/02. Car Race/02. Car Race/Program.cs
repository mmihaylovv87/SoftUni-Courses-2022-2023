using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double leftSum = 0;
            for (int i = 0; i < (numbers.Count - 1) / 2 ; i++)
            {
                leftSum += numbers[i];
                if (numbers[i] == 0) leftSum *= 0.8;
            }

            double rightSum = 0;
            for (int i = numbers.Count - 1; i >= (numbers.Count + 1) / 2; i--)
            {
                rightSum += numbers[i];
                if (numbers[i] == 0) rightSum *= 0.8;
            }

            if (leftSum > rightSum) Console.WriteLine($"The winner is right with total time: {rightSum}");
            else if (rightSum > leftSum) Console.WriteLine($"The winner is left with total time: {leftSum}");
        }
    }
}