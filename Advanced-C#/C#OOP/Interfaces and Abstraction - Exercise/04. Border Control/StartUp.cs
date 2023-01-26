using System;
using System.Collections.Generic;

namespace _04._Border_Control
{
    public class StartUp
    {
        static void Main()
        {
            List<IRobot> identities = new List<IRobot>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                IRobot identity = null;

                string[] tokens = input.Split();
                if (tokens.Length == 2)
                {
                    identity = new Robot(tokens[0], tokens[1]);
                }
                else if (tokens.Length == 3)
                {
                    identity = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                }
                identities.Add(identity);

                input = Console.ReadLine();
            }

            string endNumbers = Console.ReadLine();
            foreach (var identity in identities)
            {
                if (identity.Id.EndsWith(endNumbers))
                    Console.WriteLine(identity.Id);
            }
        }
    }
}