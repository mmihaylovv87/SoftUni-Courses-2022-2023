using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            NumberSquare(inputNumber);

        }

        static void NumberSquare(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                    if (i == number - 1 && j == number - 1)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}