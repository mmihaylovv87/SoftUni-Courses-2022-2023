using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"[!][A-Z][a-z]{2,}[!][:][[][A-z]+[]]";
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(":");
            string command = tokens[0];

            StringBuilder sb = new StringBuilder();
            for (int j = 1; j < command.Length - 1; j++)
                sb.Append(command[j]);

            string str = tokens[1];
            StringBuilder sb2 = new StringBuilder();
            for (int j = 1; j < str.Length - 1; j++)
                sb2.Append(str[j]);

            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input))
            {
                List<int> listsss = new List<int>();
                char[] chars = sb2.ToString().ToCharArray();
                for (int l = 0; l < chars.Length; l++)
                {
                    int n = (int)chars[l];
                    listsss.Add(n);
                }
                StringBuilder sb3 = new StringBuilder();
                sb3.Append($"{sb}: ");
                sb3.Append(string.Join(" ", listsss));
                Console.WriteLine($"{sb3}");
            }
            else
                Console.WriteLine("The message is invalid");
        }
    }
}