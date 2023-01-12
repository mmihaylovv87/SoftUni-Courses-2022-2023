using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var num in nums)
            {
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 0);
                }
                numbers[num]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}