using System;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(input.Where(ch => char.IsDigit(ch)).ToArray());
            Console.WriteLine(input.Where(ch => char.IsLetter(ch)).ToArray());
            Console.WriteLine(input.Where(ch => !char.IsDigit(ch) && !char.IsLetter(ch)).ToArray());
        }
    }
}