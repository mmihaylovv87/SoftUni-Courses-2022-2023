using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Print(num1, num2, num3, num4);
        }

        static void Print(int num1, int num2, int num3, int num4)
        {
            int sum1 = (num1 * num1) + (num2 * num2);
            int sum2 = (num3 * num3) + (num4 * num4);
            if (sum1 <= sum2) Console.WriteLine($"({num1}, {num2})");
            else Console.WriteLine($"({num3}, {num4})");
        }
    }
}