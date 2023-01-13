using System;
using System.Diagnostics.CodeAnalysis;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result1 = Factorial(num1);
            double rasult2 = Factorial(num2);
            PrintResult(result1, rasult2);
        }

        static void PrintResult(double result1, double result2) => Console.WriteLine($"{(result1 / result2):f2}");

        static double Factorial(double number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}