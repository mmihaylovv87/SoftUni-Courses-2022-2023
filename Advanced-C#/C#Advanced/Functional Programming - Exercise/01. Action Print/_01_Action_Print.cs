using System;

class _01_Action_Print
{
    static void Main()
    {
        Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

        string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        print(strings);
    }
}