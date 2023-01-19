using System;
using System.Linq;

class _01_Sort_Even_Numbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(",");
        int[] nums = tokens.Select(x => int.Parse(x)).ToArray();
        int[] evenNums = nums.Where(x => x % 2 == 0).ToArray();
        int[] orderedEvenNums = evenNums.OrderBy(n => n).ToArray();

        Console.WriteLine(string.Join(", ", orderedEvenNums));
    }
}