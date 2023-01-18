using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int totalCarsPassed = 0;
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalCarsPassed++;
                        }
                    }
                }
                else if (cmd == "end")
                {
                    Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
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