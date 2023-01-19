using System;
using System.Collections.Generic;
using System.Linq;

class _04_Add_VAT
{
    static void Main()
    {
        Func<decimal, decimal> addVat = x => x * 1.20m;

        string input = Console.ReadLine();
        string[] tokens = input.Split(", ");
        decimal[] nums = tokens.Select(decimal.Parse).ToArray();
        List<decimal> numsWithVAT = nums.Select(addVat).ToList();

        numsWithVAT.ForEach(x => Console.WriteLine("{0:f2}", x));
    }
}