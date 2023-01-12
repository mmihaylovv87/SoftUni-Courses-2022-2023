using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> correctNumbers = new List<int>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                int currentNumber = inputNumbers[i];
                if (currentNumber >= 0)
                {
                    correctNumbers.Add(currentNumber);
                }
            }
            correctNumbers.Reverse();
            if (correctNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", correctNumbers));
            }
        }
    }
}