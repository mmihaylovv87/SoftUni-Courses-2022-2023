using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();
        while (true)
        {
            string[] command = Console.ReadLine().Split(" ");
            string action = command[0];
            if (action == "Complete")
                break;
            else if (action == "Make")
            {
                string uplow = command[1];
                int index = int.Parse(command[2]);
                string ch = password[index].ToString();
                if (uplow == "Upper")
                    password = password.Replace(ch, ch.ToUpper());
                else if (uplow == "Lower")
                    password = password.Replace(ch, ch.ToLower());
                Console.WriteLine(password);
            }
            else if (action == "Insert")
            {
                int index = int.Parse(command[1]);
                if (index < password.Length)
                {
                    string ch = command[2];
                    password = password.Insert(index, ch);
                    Console.WriteLine(password);
                }
            }
            else if (action == "Replace")
            {
                char ch = char.Parse(command[1]);
                int value = int.Parse(command[2]);
                int chInInt = (int)ch;
                int sum = chInInt + value;
                char newCh = (char)sum;
                if (password.Contains(ch))
                {
                    password = password.Replace(ch, newCh);
                    Console.WriteLine(password);
                }
            }
            else if (action == "Validation")
            {
                if (password.Length < 8)
                    Console.WriteLine($"Password must be at least 8 characters long!");

                bool isDigitOrLetter = false;
                bool isUpperCase = false;
                bool isLowerCase = false;
                bool isDigit = false;
                foreach (var ch in password)
                {
                    if (!(char.IsLetterOrDigit(ch) || ch == '_'))
                        isDigitOrLetter = true;
                    if (char.IsUpper(ch))
                        isUpperCase = true;
                    if (char.IsLower(ch))
                        isLowerCase = true;
                    if (char.IsDigit(ch))
                        isDigit = true;
                }
                if (isDigitOrLetter)
                    Console.WriteLine($"Password must consist only of letters, digits and _!");
                if (!isUpperCase)
                    Console.WriteLine($"Password must consist at least one uppercase letter!");
                if (!isLowerCase)
                    Console.WriteLine($"Password must consist at least one lowercase letter!");
                if (!isDigit)
                    Console.WriteLine($"Password must consist at least one digit!");
            }
        }
    }
}