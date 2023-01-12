using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string firstName = tokens[0];
                string secondName = tokens[1];
                double grade = double.Parse(tokens[2]);
                Student student = new Student(firstName, secondName, grade);
                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade / 100:f2}");
            }
        }
    }
}