﻿using System;

namespace _09._SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHER = 100;
            const int DAILY_DECREES_OF_MINE_YIELD = 10;

            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounter = 0;

            while (countOfSpices >= MINIMUM_SPICES_TO_GATHER)
            {
                totalConsumed += countOfSpices - CONSUMED_BY_WORKERS;
                countOfSpices -= DAILY_DECREES_OF_MINE_YIELD;
                daysCounter++;
                if (countOfSpices < MINIMUM_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalConsumed);
        }
    }
}