using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] courseOfPerson = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> peopleInCourses = new Dictionary<string, List<string>>();

            while (courseOfPerson[0] != "end")
            {
                string courseName = courseOfPerson[0];
                string personName = courseOfPerson[1];
                if (!peopleInCourses.ContainsKey(courseName))
                {
                    peopleInCourses[courseName] = new List<string>();
                }
                peopleInCourses[courseName].Add(personName);

                courseOfPerson = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            PrintCoursesInfo(peopleInCourses);
        }

        private static void PrintCoursesInfo(Dictionary<string, List<string>> peopleIncourses)
        {
            foreach (var kvp in peopleIncourses)
            {
                string courseName = kvp.Key;
                var students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}