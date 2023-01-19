using System;
using System.Collections.Generic;
using System.Linq;

class _02_Sets_of_Elements
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        int[] counts = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();

        for (int i = 0; i < counts[0]; i++)
            set1.Add(int.Parse(Console.ReadLine()));

        for (int i = 0; i < counts[1]; i++)
            set2.Add(int.Parse(Console.ReadLine()));

        set1.IntersectWith(set2);
        Console.WriteLine(string.Join(" ", set1));
    }
}