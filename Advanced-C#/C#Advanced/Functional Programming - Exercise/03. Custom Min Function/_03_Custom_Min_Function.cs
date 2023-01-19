using System;
using System.Linq;

class _03_Custom_Min_Function
{
    static void Main()
    {
        //Func<int[], int> minNumber = numbers => numbers.Min();

        //int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
        //Console.WriteLine(minNumber(numbers));

        Func<int[], int> minNumber = numbers =>
        {
            int min = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        };

        int[] numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();

        Console.WriteLine(minNumber(numbers));
    }
}