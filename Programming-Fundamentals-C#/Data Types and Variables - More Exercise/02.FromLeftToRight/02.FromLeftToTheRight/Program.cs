using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int sum = 0;
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];
                if (firstNumber >= secondNumber)
                {
                    while (firstNumber > 0)
                    {
                        sum += firstNumber % 10;
                        firstNumber /= 10;
                    }
                }
                else
                {
                    while (secondNumber > 0)
                    {
                        sum += secondNumber % 10;
                        secondNumber /= 10;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}