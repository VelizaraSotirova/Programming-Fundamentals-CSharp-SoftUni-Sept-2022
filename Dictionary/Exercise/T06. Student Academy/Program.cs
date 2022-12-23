using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentInfo
                = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentInfo.ContainsKey(studentName))
                {
                    studentInfo.Add(studentName, new List<double>());
                }
                studentInfo[studentName].Add(grade);
            }

            Console.WriteLine(String.Join($"{Environment.NewLine}", studentInfo
                .Where(x => (x.Value.Sum() / x.Value.Count) >= 4.50)
                //.OrderByDescending(x => (x.Value.Sum() / x.Value.Count))
                .Select(x => $"{x.Key} -> {x.Value.Sum() / x.Value.Count():f2}")));
        }
    }
}
