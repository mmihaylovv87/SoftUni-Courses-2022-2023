using System;

namespace _05._06._Generic_Count_Method
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                box.Items.Add(item);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}