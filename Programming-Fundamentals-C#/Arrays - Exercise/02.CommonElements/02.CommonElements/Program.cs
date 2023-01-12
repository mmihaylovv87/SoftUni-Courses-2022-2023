using System;
using System.Runtime.InteropServices;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(' ');
            string[] arrTwo = Console.ReadLine().Split(' ');

            foreach (string currElement in arrOne)
            {
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    string secondCurrElement = arrTwo[i];
                    if (currElement == secondCurrElement)
                    {
                        Console.Write($"{currElement} ");
                        break;
                    }
                }
            }
        }
    }
}
