using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudent; i++)
            {
                string[] currStudentInfo = Console.ReadLine().Split(" ");
                Student student = new Student(currStudentInfo[0], currStudentInfo[1], double.Parse(currStudentInfo[2]));
                students.Add(student);
            }
            students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    }
}