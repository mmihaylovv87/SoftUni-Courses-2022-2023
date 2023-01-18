using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            var arr = stack.ToArray();

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}