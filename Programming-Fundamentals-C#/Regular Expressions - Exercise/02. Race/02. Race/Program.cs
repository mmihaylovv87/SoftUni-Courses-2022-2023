using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex patternForName = new Regex(@"(?<name>[A-Za-z])");
            string patternForDigits = @"(?<digits>\d+)";
            int sumOfDigits = 0;

            Dictionary<string, int> participants = new Dictionary<string, int>();
            List<string> names = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchedNames = patternForName.Matches(input);
                MatchCollection matchedDigits = Regex.Matches(input, patternForDigits);
                string currName = string.Join("", matchedNames);
                string currDigits = string.Join("", matchedDigits);

                sumOfDigits = 0;
                for (int i = 0; i < currDigits.Length; i++)
                {
                    sumOfDigits += int.Parse(currDigits[i].ToString());
                }

                if (names.Contains(currName))
                {
                    if (!participants.ContainsKey(currName))
                    {
                        participants.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        participants[currDigits] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            var winners = participants.OrderByDescending(x => x.Value).Take(3);
            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);

            foreach (var firstname in firstPlace)
            {
                Console.WriteLine($"1st place: {firstname.Key}");
            }
            foreach (var secondname in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondname.Key}");
            }
            foreach (var thirdname in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdname.Key}");
            }
        }
    }
}