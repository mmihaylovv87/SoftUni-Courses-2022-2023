using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Select(word => word.ToLower())
                .ToArray();
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts.Add(word, 0);
                }

                wordCounts[word]++;
            }

            string[] oddCountWords = wordCounts
                .Where(w => w.Value % 2 != 0)
                .Select(w => w.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", oddCountWords));
        }
    }
}