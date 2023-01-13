using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teams = new Dictionary<string, string>();
            teams.Add("Ivan", "Petrov");
            teams.Add("Petar", "Hristov");
            Console.WriteLine(teams.Keys.Contains("Ivan"));
        }
    }
}
