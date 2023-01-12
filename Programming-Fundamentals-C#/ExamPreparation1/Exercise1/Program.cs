using System;
using System.Linq;
using System.Text;

namespace Exercise1
{
    public class Program
    {
        public static void Main()
        {
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(message);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Reveal")
                {
                    Console.WriteLine($"You have a new text message: {sb}");
                    break;
                }

                string[] commandInfo = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandInfo[0];
                if (commandName == "InsertSpace")
                {
                    int index = int.Parse(commandInfo[1]);
                    sb.Insert(index, " ");
                    Console.WriteLine(sb);
                }
                else if (commandName == "Reverse")
                {
                    string substring = commandInfo[1];
                    int startIndex = sb.ToString().IndexOf(substring);

                    if (startIndex != -1)
                    {
                        sb.Remove(startIndex, substring.Length);
                        sb.Append(string.Join("", substring.Reverse()));
                        Console.WriteLine(sb);
                    }
                    else Console.WriteLine("error");
                }
                else if (commandName == "ChangeAll")
                {
                    string substring = commandInfo[1];
                    string replacement = commandInfo[2];
                    sb.Replace(substring, replacement);
                    Console.WriteLine(sb);
                }
            }
        }
    }
}