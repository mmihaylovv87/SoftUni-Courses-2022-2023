using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            SearchForVowels(inputText);
        }

        static void SearchForVowels(string text)
        {
            // Console.WriteLine(text.Count(vowles => "aeiou".Contains(vowles)));
            int count = 0;
            foreach (char vowel in text)
            { 
                if ("aouei".Contains(vowel))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}