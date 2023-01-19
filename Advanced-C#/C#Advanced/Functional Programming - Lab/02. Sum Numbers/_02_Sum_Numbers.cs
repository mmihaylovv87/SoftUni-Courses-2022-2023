using System;
using System.Linq;

class _02_Sum_Numbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] nums = input.Split(", ").Select(Parse).ToArray();
        Console.WriteLine(nums.Count());
        Console.WriteLine(nums.Sum());
    }

    static int Parse(string str) => int.Parse(str);
}