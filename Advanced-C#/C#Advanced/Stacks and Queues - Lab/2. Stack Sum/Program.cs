﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            while (true)
            {
                string cmd = Console.ReadLine().ToLower();
                string[] cmdItems = cmd.Split(' ');
                if (cmdItems[0] == "add")
                {
                    int n1 = int.Parse(cmdItems[1]);
                    int n2 = int.Parse(cmdItems[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (cmdItems[0] == "remove")
                {
                    int count = int.Parse(cmdItems[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (cmdItems[0] == "end")
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    break;
                }
            }
        }
    }
}