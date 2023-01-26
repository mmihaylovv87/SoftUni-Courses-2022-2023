using System;
using System.Collections.Generic;
namespace _06._Food_Shortage
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, IBuyer> humans = new Dictionary<string, IBuyer>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string name = inputInfo[0];
                int age = int.Parse(inputInfo[1]);

                if (inputInfo.Length == 3)
                {
                    string group = inputInfo[2];
                    humans[name] = new Rebel(name, age, group);
                }
                else if (inputInfo.Length == 4)
                {
                    string id = inputInfo[2];
                    string birthdate = inputInfo[3];
                    humans[name] = new Citizen(name, age, id, birthdate);
                }
            }

            int sum = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                    break;

                if (humans.ContainsKey(name))
                {
                    IBuyer buyer = humans[name];
                    sum += buyer.BuyFood();
                }
            }

            Console.WriteLine(sum);
        }
    }
}