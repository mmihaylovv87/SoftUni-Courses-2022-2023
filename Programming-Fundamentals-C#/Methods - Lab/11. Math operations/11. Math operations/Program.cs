using System;
using System.Security.Permissions;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operation = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = Calculate(a, operation, b);
            Console.WriteLine(result);
        }

        static double Calculate(int a, string @operation, int b)
        {
            double result = 0;
            switch (@operation)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}