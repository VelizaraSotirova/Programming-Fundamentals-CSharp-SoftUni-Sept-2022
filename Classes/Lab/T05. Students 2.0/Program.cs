using System;
using System.Linq;
using System.Collections.Generic;

namespace T05._Students_2._0
{
        internal class Program
        {
            static void Main(string[] args)
            {
                string input = Console.ReadLine();
                List<Student> students = new List<Student>();

                while (input != "end")
                {
                    string[] studentInfo = input.Split(' ');
                    string studentFirstName = studentInfo[0];
                    string studentLastName = studentInfo[1];
                    int studentAge = int.Parse(studentInfo[2]);
                    string studentTown = studentInfo[3];

                    Student student = students
                       .FirstOrDefault(x => x.FirstName == studentFirstName 
                                         && x.LastName == studentLastName);

                    if (student != null)
                    {
                         student.Town = studentTown;
                         student.Age = studentAge;
                    }
                    else
                    {
                        student = new Student(studentFirstName, studentLastName, studentAge, studentTown);
                        students.Add(student);
                    }

                    input = Console.ReadLine();
                }

                string townName = Console.ReadLine();
                foreach (Student currStudent in students)
                {
                    if (currStudent.Town == townName)
                    {
                        Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                    }
                }
            }
        }
        public class Student
        {
            public Student(string firstName, string lastName, int age, string town)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Town = town;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
}
   