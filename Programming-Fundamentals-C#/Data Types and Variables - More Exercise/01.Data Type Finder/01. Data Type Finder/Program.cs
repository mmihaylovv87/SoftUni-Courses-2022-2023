using System;
using System.Linq;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "True" || input == "False")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (int.Parse(input) * 0 == 0)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.Parse(input) * 0 == 0)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (input.Length < 2)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}