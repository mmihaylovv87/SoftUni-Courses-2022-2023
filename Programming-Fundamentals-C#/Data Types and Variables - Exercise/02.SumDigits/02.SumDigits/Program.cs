using System;

namespace _02._SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int finalSum = 0;

            while (numInput != 0)
            {
                int LastDigit = numInput % 10;
                finalSum += LastDigit;
                numInput /= 10;
            }

            Console.WriteLine(finalSum);
        }
    }
}