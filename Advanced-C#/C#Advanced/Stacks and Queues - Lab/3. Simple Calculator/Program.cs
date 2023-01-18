using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);
            int sum = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());
                if (operation == "+")
                {
                    sum += number;
                }
                else if (operation == "-")
                {
                    sum -= number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}