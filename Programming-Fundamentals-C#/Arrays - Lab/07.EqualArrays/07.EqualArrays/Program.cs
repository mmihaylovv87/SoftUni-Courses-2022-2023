using System;
using System.ComponentModel;
using System.Linq;

namespace _07._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    return;
                }
                else
                {
                    sum += firstArray[index];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}