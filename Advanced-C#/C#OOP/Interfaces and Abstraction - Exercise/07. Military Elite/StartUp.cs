using _07._Military_Elite.Interfaces;
using System;
using System.Collections.Generic;

namespace _07._Military_Elite
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split();
                string action = tokens[0];
                int id = int.Parse(tokens[1]);

                if (action == "Private")
                {
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    decimal salary = decimal.Parse(tokens[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(id, @private);
                }
                else if (action == "LieutenantGeneral")
                {
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    decimal salary = decimal.Parse(tokens[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                    
                    for (int i = 5; i < tokens.Length; i++)
                    {
                        int inputId = int.Parse(tokens[i]);
                        IPrivate @private = soldiers[inputId] as IPrivate;
                        lieutenantGeneral.Privates.Add(@private);
                    }
                    soldiers.Add(id, lieutenantGeneral);
                }
                else if (action == "Engineer")
                {
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    decimal salary = decimal.Parse(tokens[4]);
                    string corpAsString = tokens[5];

                    bool isValidEnum = Enum.TryParse(corpAsString, out Corps result);
                    if (!isValidEnum) 
                        continue;

                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);
                    for (int i = 6; i < tokens.Length; i += 2)
                    {
                        string partName = tokens[i];
                        int hours = int.Parse(tokens[i + 1]);

                        IRepair repair = new Repair(partName, hours);
                        engineer.Repairs.Add(repair);
                    }

                    soldiers.Add(id, engineer);
                }
                else if (action == "Commando")
                {
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    decimal salary = decimal.Parse(tokens[4]);
                    string corpAsString = tokens[5];

                    bool isValidEnum = Enum.TryParse(corpAsString, out Corps result);
                    if (!isValidEnum)
                        continue;

                    ICommando commando = new Commando(id, firstName, lastName, salary, result);
                    for (int i = 6; i < tokens.Length; i += 2)
                    {
                        string missionCode = tokens[i];
                        string missionStateAsString = tokens[i + 1];

                        bool isValidMission = Enum.TryParse(missionStateAsString, out Status status);
                        if (!isValidMission)
                            continue;

                        IMission mission = new Mission(missionCode, status);
                        commando.Missions.Add(mission);
                    }
                    soldiers.Add(id, commando);
                }
                else if (action == "Spy")
                {
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    int codeNumber = int.Parse(tokens[4]);
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(id, spy);
                }
                input = Console.ReadLine();
            }

            foreach (var item in soldiers)
                Console.WriteLine(item.Value.ToString());
        }
    }
}