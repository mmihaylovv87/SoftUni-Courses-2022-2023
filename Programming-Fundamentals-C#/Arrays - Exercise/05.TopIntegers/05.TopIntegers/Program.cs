﻿using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool currIterattionNumIsBigger = true;
                for (int j = i + 1; j  < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j]) 
                    {
                        currIterattionNumIsBigger = false;
                    }
                }

                if (currIterattionNumIsBigger)
                {
                    Console.Write($"{inputArray[i]} ");

                }
            }
        }
    }
}
