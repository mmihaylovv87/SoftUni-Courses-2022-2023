using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            PrintMiddleChar(inputText);
        }

        static void PrintMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write($"{text[(text.Length / 2) - 1]}{text[text.Length / 2]}");
            }
            else if (text.Length % 2 == 1)
            {
                Console.Write($"{text[(text.Length - 1) / 2]}");
            }
        }
    }
}