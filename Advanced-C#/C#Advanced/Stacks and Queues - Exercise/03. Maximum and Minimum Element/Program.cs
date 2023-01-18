using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int numberOfCommand = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfCommand; i++)
            {
                int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int command = inputNumbers[0];

                if (command == 1)
                {
                    int number = inputNumbers[1];
                    stack.Push(number);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    if (stack.Count > 0) Console.WriteLine(stack.Max());
                }
                else if (command == 4)
                {
                    if (stack.Count > 0) Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}