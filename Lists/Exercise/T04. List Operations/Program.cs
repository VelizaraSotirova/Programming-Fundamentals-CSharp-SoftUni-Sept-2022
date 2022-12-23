using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int value = int.Parse(cmdArgs[1]);
                    numbers.Add(value);
                }
                else if (cmdType == "Insert")
                {
                    int value = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, value);
                }
                else if (cmdType == "Remove")
                {
                    int value = int.Parse(cmdArgs[1]);

                    if (IsIndexInvalid(numbers, value))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(value);
                }
                else if (cmdType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }

            Console.WriteLine(String.Join(' ', numbers));
        }

        static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
