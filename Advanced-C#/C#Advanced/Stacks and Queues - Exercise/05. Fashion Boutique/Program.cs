using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(numbers);

            int rackCapacity = int.Parse(Console.ReadLine());
            int rackUsed = 0;

            while (clothes.Count > 0)
            {
                int clothesCountInRack = 0;
                while (clothesCountInRack + clothes.Peek() <= rackCapacity)
                {
                    clothesCountInRack += clothes.Pop();
                    if (clothes.Count == 0) 
                        break;
                }
                rackUsed++;
            }
            Console.WriteLine(rackUsed);
        }
    }
}