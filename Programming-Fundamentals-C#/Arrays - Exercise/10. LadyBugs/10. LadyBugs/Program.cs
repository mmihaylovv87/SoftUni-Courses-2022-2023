using System;
using System.Collections.Generic;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                foreach (char letter in name)
                {
                    if (letter == 'a' || letter == 'o' || letter == 'u' || letter == 'e' || letter == 'i')
                    {
                        sum += letter * name.Length;
                    }
                    else
                    {
                        sum += letter / name.Length;
                    }
                }

                numbers.Add(sum);
            }

            numbers.Sort();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}