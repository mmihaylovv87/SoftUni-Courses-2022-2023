using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] integers = ArrayCreator.Create(10, 42);
            Console.WriteLine(string.Join(" ", integers));

            string[] strings = ArrayCreator.Create(10, "Hello");
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}