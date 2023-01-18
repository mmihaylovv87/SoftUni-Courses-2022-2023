using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int rowsAndColsCount = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsAndColsCount, rowsAndColsCount];

            for (int row = 0; row < rowsAndColsCount; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowsAndColsCount; col++)
                    matrix[row, col] = input[col];
            }
            char searched = Console.ReadLine().ToCharArray()[0];
            for (int row = 0; row < rowsAndColsCount; row++)
            {
                for (int col = 0; col < rowsAndColsCount; col++)
                {
                    if (searched == matrix[row, col])
                    {
                        Console.Write($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{searched} does not occur in the matrix");
        }
    }
}