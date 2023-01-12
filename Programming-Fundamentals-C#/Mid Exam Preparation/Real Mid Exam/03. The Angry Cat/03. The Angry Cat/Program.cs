using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (command == "cheap" && numbers[i] < numbers[index])
                {
                    if (i < index)
                    {
                        sumLeft += numbers[i];
                    }
                    else if (i > index)
                    {
                        sumRight += numbers[i];
                    }
                }
                else if (command == "expensive" && numbers[i] >= numbers[index])
                {
                    if (i < index)
                    {
                        sumLeft += numbers[i];
                    }
                    else if (i > index)
                    {
                        sumRight += numbers[i];
                    }
                }
            }

            if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {sumRight}");
            }
        }
    }
}