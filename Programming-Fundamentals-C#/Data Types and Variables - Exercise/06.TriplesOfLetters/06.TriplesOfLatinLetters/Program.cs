using System;

namespace _06._TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfChars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfChars; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < countOfChars; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < countOfChars; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}