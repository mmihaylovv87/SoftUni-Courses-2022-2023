using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> correctList = new List<int>();
            int startNumber = 0;
            int endNumber = 0;

            if (firstList.Count > secondList.Count)
            {
                if (firstList[firstList.Count - 1] > firstList[firstList.Count - 2])
                {
                    startNumber = firstList[firstList.Count - 2];
                    endNumber = firstList[firstList.Count - 1];
                }
                else
                {
                    startNumber = firstList[firstList.Count - 1];
                    endNumber = firstList[firstList.Count - 2];
                }
                for (int i = 0; i < firstList.Count - 2; i++)
                {
                    if (firstList[i] > startNumber && firstList[i] < endNumber) correctList.Add(firstList[i]);
                    if (secondList[i] > startNumber && secondList[i] < endNumber) correctList.Add(secondList[i]);
                }
            }
            else
            {
                if (secondList[1] > secondList[0])
                {
                    startNumber = secondList[0];
                    endNumber = secondList[1];
                }
                else
                {
                    startNumber = secondList[1];
                    endNumber = secondList[0];
                }
                for (int i = 2; i < secondList.Count; i++)
                {
                    if (firstList[i - 2] > startNumber && firstList[i - 2] < endNumber) correctList.Add(firstList[i - 2]);
                    if (secondList[i] > startNumber && secondList[i] < endNumber) correctList.Add(secondList[i]);
                }
            }
            correctList.Sort();
            Console.WriteLine(string.Join(" ", correctList));
        }
    }
}