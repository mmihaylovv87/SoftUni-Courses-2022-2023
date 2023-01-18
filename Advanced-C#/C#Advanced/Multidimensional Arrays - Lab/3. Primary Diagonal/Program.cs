using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int diagonal = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                int[] cols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                diagonal += cols[i];
            }
            Console.WriteLine(diagonal);
        }
    }
}