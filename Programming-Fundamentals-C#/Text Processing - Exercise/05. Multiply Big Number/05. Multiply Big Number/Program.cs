﻿using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNumber = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (num == 1)
            {
                Console.WriteLine(reallyBigNumber);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = reallyBigNumber.Length - 1; i >= 0; i--)
            {
                char lastNum = reallyBigNumber[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int result = lastNumAsDigit * num + remainder;

                sb.Append(result % 10);
                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reversedString = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedString.Append(sb[i]);
            }

            Console.WriteLine(reversedString);
        }
    }
}