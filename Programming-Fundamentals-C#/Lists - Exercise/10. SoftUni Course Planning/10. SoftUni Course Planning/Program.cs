using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonTitles = Console.ReadLine().Split(", ").ToList();
            Dictionary<int, string> lessonsAfterAllCommands = new Dictionary<int, string>();
            
            for (int i = 0; i < lessonTitles.Count; i++)
            {
                lessonsAfterAllCommands.Add(i + 1, lessonTitles[i]);
            }
            
            while (true)
            {
                string[] commands = Console.ReadLine().Split(":");
                string command = commands[0];
                string lesson = commands[1];
                if (command == "course")
                    break;

                if (command == "Swap")
                {
                    string secondLesson = commands[2];
                    
                }
                
            }
        }
    }
}