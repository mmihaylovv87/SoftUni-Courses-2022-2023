using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split($"{(char)92}");
            string str = input[input.Length - 1];
            string[] currInput = str.Split(".");
            Console.WriteLine($"File name: {currInput[0]}");
            Console.WriteLine($"File extension: {currInput[1]}");
        }
    }
}