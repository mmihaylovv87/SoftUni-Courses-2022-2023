using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> gaussNumbers = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentGaussNumber = numbers[i] + numbers[numbers.Count - 1 - i];
                gaussNumbers.Add(currentGaussNumber);
            }

            if (numbers.Count % 2 == 1)
            {
                gaussNumbers.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(String.Join(" ", gaussNumbers));

            //  List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //  int originalLength = numbers.Count;
            //  for (int i = 0; i < originalLength / 2; i++)
            //  {
            //      numbers[i] += numbers[numbers.Count - 1];
            //      numbers.RemoveAt(numbers.Count - 1);
            //  }
            //  Console.WriteLine(string.Join(" ", numbers));
        }
    }
}