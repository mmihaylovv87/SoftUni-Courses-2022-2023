using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int addedResult = Add(firstNumber, secondNumber);
            int finalResult = Subtract(addedResult, thirdNumber);
            PrintResult(finalResult);
        }

        static int Add(int firstNumber, int secondNumber) => firstNumber + secondNumber;

        static int Subtract(int addedResult, int thirdNumber) => addedResult - thirdNumber;

        static void PrintResult(int number) => Console.WriteLine(number);

    }
}