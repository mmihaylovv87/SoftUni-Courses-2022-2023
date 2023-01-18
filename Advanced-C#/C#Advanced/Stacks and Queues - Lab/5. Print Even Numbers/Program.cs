using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            while (queue.Count() > 0)
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    Console.Write(number);
                    if (queue.Count() > 0) Console.Write(", ");
                }
            }
        }
    }
}