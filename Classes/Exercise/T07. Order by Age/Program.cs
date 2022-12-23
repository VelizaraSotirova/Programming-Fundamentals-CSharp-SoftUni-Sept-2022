using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace T07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> person = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                if (person.Any(x => x.ID == id))
                {
                    int index = person.FindIndex(x => x.ID == id);
                    person.RemoveAt(index);
                }

                Person currPerson = new Person(name, id, age);
                person.Add(currPerson);
            }

            person = person
                .OrderBy(x => x.Age)
                .ToList();

            var finalPeople = FormatUserList(person);
            Console.WriteLine(finalPeople);
        }

        public static string FormatUserList(List<Person> users)
        {
            var result = new StringBuilder();
            foreach (Person item in users)
            {
                result.AppendLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }

            return result.ToString().TrimEnd();
        }
    }


    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
