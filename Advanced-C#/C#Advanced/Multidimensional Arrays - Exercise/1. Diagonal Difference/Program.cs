using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int n2 = n;
            for (int i = 0; i < n; i++)
            {
                int[] cols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                primaryDiagonal += cols[i];
                secondaryDiagonal += cols[--n2];
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}