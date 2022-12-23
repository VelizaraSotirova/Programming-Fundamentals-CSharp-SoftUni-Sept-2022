using System;
using System.Linq;
using System.Collections.Generic;

namespace T04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];   
                decimal grade = decimal.Parse(studentInfo[2]);

                Student currentStudent = new Student(firstName, lastName, grade);

                students.Add(currentStudent);
            }

            List<Student> orderedStudents = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }
    }
}
