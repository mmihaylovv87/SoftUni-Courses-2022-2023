using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var companyName = tokens[0];
                var employeId = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (companies[companyName].Contains(employeId)) 
                { 
                    command = Console.ReadLine();
                    continue;
                }

                companies[companyName].Add(employeId);
                command = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}