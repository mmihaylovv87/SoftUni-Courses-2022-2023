using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else if (cmd == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    return;
                }
                else
                {
                    queue.Enqueue(cmd);
                }
            }
        }
    }
}