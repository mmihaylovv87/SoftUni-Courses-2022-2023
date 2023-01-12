using System;

class Program
{
    static void Main()
    {
        string activationKey = Console.ReadLine();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Generate")
            {
                Console.WriteLine($"Your activation key is: {activationKey}");
                break;
            }

            string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            string action = tokens[0];
            if (action == "Contains")
            {
                string substring = tokens[1];
                if (activationKey.Contains(substring))
                    Console.WriteLine($"{activationKey} contains {substring}");
                else
                    Console.WriteLine("Substring not found!");
            }
            else if (action == "Flip")
            {
                string cmd = tokens[1];
                int startIndex = int.Parse(tokens[2]);
                int endIndex = int.Parse(tokens[3]);

                string changedChars = activationKey.Substring(startIndex, endIndex - startIndex);
                if (cmd == "Upper")
                    activationKey = activationKey.Replace(changedChars, changedChars.ToUpper());
                else if (cmd == "Lower")
                    activationKey = activationKey.Replace(changedChars, changedChars.ToLower());
                Console.WriteLine(activationKey);
            }
            else if (action == "Slice")
            {
                int startIndex = int.Parse(tokens[1]);
                int endIndex = int.Parse(tokens[2]);
                activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                Console.WriteLine(activationKey);
            }
        }
    }
}