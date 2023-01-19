using System;
using System.Collections.Generic;

class _05_Count_Symbols
{
    static void Main()
    {
        SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (!charsCount.ContainsKey(ch)) 
                charsCount.Add(ch, 0);
            charsCount[ch]++;
        }

        foreach (KeyValuePair<char, int> ch in charsCount)
        {
            Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
        }
    }
}