using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> allNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < allNumbers.Count - 1; i++)
            {
                if (allNumbers[i] == allNumbers[i + 1])
                {
                    allNumbers[i] += allNumbers[i + 1];
                    allNumbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", allNumbers));
        }
    }
}