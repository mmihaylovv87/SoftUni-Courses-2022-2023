using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0])) 
                    vipGuests.Add(input);
                else
                    regularGuests.Add(input);
            }
            while ((input = Console.ReadLine()) != "END")
            {
                vipGuests.Remove(input);
                regularGuests.Remove(input);
            }
            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            if (vipGuests.Count > 0)
                Console.WriteLine(String.Join("\n", vipGuests));

            if (regularGuests.Count > 0)
                Console.WriteLine(String.Join("\n", regularGuests));
        }
    }
}