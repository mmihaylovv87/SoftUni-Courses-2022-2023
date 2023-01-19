using System;
using System.Collections.Generic;

class _03_Periodic_Table
{
    static void Main()
    {
        SortedSet<string> periodicElements = new SortedSet<string>();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            periodicElements.UnionWith(elements);
        }
        Console.WriteLine(string.Join(" ", periodicElements));
    }
}