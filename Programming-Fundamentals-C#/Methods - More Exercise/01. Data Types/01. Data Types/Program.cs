using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            Print(input1, input2);
        }

        static void Print(string input1, string input2)
        {
            if (input1 == "int") Console.WriteLine(int.Parse(input2) * 2);
            else if (input1 == "real") Console.WriteLine($"{(double.Parse(input2) * 1.5):f2}");
            else if (input1 == "string") Console.WriteLine($"${input2}$");
        }
    }
}