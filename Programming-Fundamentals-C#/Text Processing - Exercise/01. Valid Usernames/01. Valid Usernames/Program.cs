using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in input)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;
                    for (int i = 0; i < username.Length; i++)
                    {
                        char currentChar = username[i];
                        if (!(currentChar == '_' || currentChar == '-' || char.IsLetter(currentChar) || char.IsDigit(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}