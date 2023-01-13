using System;
using System.ComponentModel.DataAnnotations;

namespace _01._Smallest_of_Three_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(LowerNumber(firstNumber, secondNumber, thirdNumber));
        }

        static int LowerNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}