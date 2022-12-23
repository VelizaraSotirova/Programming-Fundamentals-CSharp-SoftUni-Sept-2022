using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split();

                if (cmdArgs.Length == 2)
                {
                    int newPassengers = int.Parse(cmdArgs[1]);

                    passengersInWagon.Add(newPassengers);
                }
                else if (cmdArgs.Length == 1)
                {
                    int newPassengers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < passengersInWagon.Count; i++)
                    {
                        if (passengersInWagon[i] + newPassengers <= maxCapacityOfWagon)
                        {
                            passengersInWagon[i] += newPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", passengersInWagon));
        }
    }
}
