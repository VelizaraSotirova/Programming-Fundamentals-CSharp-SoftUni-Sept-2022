using System;
using System.Linq;
using System.Collections.Generic;

namespace T07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers
                = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" -> ");
                string companyName = cmdArgs[0];
                string ID = cmdArgs[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }
                if (!companyUsers[companyName].Contains(ID))
                {
                    companyUsers[companyName].Add(ID);
                }
            }

            foreach (var company in companyUsers)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
