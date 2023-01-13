using System;

namespace _10._Top_Number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int sum = 0; // сума за проверка дали числото се дели на 8 

                int currentNumber = i; // текущо число
                int secondNumber = currentNumber;// ще пази стойността след % деление

                int count = 0; // имали нечетни числа

                while (secondNumber > 0)
                {
                    currentNumber = secondNumber % 10; //взимам последното число  / 11->1 12->2
                    secondNumber = secondNumber / 10; // присвоявам първото число  от currentNumber (остатък)

                    if (currentNumber % 2 != 0)
                    {
                        count++;
                    }

                    sum += currentNumber;
                }

                if (sum % 8 == 0 && count > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}