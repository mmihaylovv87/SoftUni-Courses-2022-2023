using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            string resources = Console.ReadLine();
            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resources))
                {
                    items[resources] = quantity;
                }
                else
                {
                    items[resources] += quantity;
                }
                resources = Console.ReadLine();
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}