using System;
using System.Linq;
using System.Collections.Generic;

namespace T02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if (command == "Delete")
                {
                    int value = int.Parse(cmdArgs[1]);
                    numbers.RemoveAll(x => x == value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, value);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
