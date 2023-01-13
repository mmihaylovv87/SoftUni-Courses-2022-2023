using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber < 0) firstNumber = -1;
            else if (firstNumber > 0) firstNumber = 1;
            if (secondNumber < 0) secondNumber = -1;
            else if (secondNumber > 0) secondNumber = 1;
            if (thirdNumber < 0) thirdNumber = -1;
            else if (thirdNumber > 0) thirdNumber = 1;

            if (firstNumber + secondNumber + thirdNumber == 3 || firstNumber + secondNumber + thirdNumber == -1) Console.WriteLine("positive");
            else if (firstNumber + secondNumber + thirdNumber == 2 || firstNumber + secondNumber + thirdNumber == 0 || firstNumber + secondNumber + thirdNumber == -2) Console.WriteLine("zero");
            else if (firstNumber + secondNumber + thirdNumber == 1 || firstNumber + secondNumber + thirdNumber == -3) Console.WriteLine("negative");
        }
    }
}