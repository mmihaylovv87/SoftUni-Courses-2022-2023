using System;

namespace _02._PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int[] numbersLength = new int[countOfNumbers];

            for (int i = 0; i < countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersLength[i] = number;
            }

            for (int i = (countOfNumbers - 1); i >= 0; i--)
            {
                Console.Write($"{numbersLength[i]} ");
            }

        }
    }
}