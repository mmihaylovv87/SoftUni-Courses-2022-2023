using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] tokens = Console.ReadLine().Split();
            string command = tokens[0];
            while (command != "End")
            {
                if (command == "Shoot")
                {
                    int index = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);
                    if (index < numbers.Count)
                    {
                        numbers[index] -= power;
                        if (numbers[index] <= 0)
                        {
                            numbers.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);
                    if (index < numbers.Count)
                    {
                        numbers[index] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);
                    if (index + radius >= numbers.Count || index - radius < 0)
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    else 
                    {
                        int countRemoveNumbers = 2 * radius + 1;
                        for (int i = 0; i < countRemoveNumbers; i++)
                        {
                            numbers.RemoveAt(index - radius);
                        }
                    }
                }
                tokens = Console.ReadLine().Split();
                command = tokens[0];
            }
            Console.WriteLine(string.Join("|", numbers));
        }
    }
}