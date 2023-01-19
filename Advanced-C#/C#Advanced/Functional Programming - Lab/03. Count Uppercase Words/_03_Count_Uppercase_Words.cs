using System;
using System.Linq;

class _03_Count_Uppercase_Words
{
    static void Main() => 
        Console.WriteLine(string.Join("\r\n", Console.ReadLine().Split(" ").Where(x => x.Length > 0 && char.IsUpper(x[0]))).ToArray());

        //Predicate<string> isCapitalFirstLetter = (string x) => x.Length > 0 && char.IsUpper(x[0]);
}