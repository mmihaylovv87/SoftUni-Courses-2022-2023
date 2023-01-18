using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            Queue<int> ordersQueue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Console.WriteLine(ordersQueue.Max());

            int countOrders = ordersQueue.Count;
            for (int order = 0; order < countOrders; order++)
            {
                if (quantityFood >= ordersQueue.Peek()) 
                    quantityFood -= ordersQueue.Dequeue();
                else
                    break;
            }
            if (ordersQueue.Count == 0) 
                Console.WriteLine("Orders complete");
            else 
                Console.WriteLine("Orders left: " + string.Join(" ", ordersQueue));
        }
    }
}