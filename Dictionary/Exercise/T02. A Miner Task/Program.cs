using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resources
                = new Dictionary<string, double>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                double quontity = double.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quontity;
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
