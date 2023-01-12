using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isListChanged = false;
            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                if (command == "end")
                {
                    break;
                }

                if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    inputNumbers.Add(number);
                    isListChanged = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    inputNumbers.Remove(number);
                    isListChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    inputNumbers.RemoveAt(index);
                    isListChanged = true;
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    inputNumbers.Insert(index, number);
                    isListChanged = true;
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (inputNumbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    foreach (int number in inputNumbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "PrintOdd")
                {
                    foreach (int number in inputNumbers)
                    {
                        if (number % 2 == 1)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(inputNumbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = tokens[1];
                    int number = int.Parse(tokens[2]);
                    if (condition == "<")
                    {
                        for (int i = 0; i < inputNumbers.Count; i++)
                        {
                            if (inputNumbers[i] < number)
                            {
                                Console.Write($"{inputNumbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        for (int i = 0; i < inputNumbers.Count; i++)
                        {
                            if (inputNumbers[i] <= number)
                            {
                                Console.Write($"{inputNumbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < inputNumbers.Count; i++)
                        {
                            if (inputNumbers[i] >= number)
                            {
                                Console.Write($"{inputNumbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">")
                    {
                        for (int i = 0; i < inputNumbers.Count; i++)
                        {
                            if (inputNumbers[i] > number)
                            {
                                Console.Write($"{inputNumbers[i]} ");
                            }
                        }
                    }
                }
            }
            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ", inputNumbers));
            }
        }
    }
}