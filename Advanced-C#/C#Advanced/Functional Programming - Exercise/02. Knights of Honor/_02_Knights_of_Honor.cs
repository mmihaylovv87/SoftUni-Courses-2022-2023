using System;

class _02_Knights_of_Honor
{
    static void Main()
    {
        Action<string[], string> printNames = (names, title) =>
        {
            foreach (var name in names)
            {
                Console.WriteLine($"{title} {name}");
            }
        };
        
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        printNames(names, "Sir");
    }
}