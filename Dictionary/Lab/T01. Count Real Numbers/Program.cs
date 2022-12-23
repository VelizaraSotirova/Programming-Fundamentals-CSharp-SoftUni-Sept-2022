using System;
using System.Linq;
using System.Collections.Generic;

namespace T01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            double[] numbersInput = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var currNumber in numbersInput)
            {
                if (!numbers.ContainsKey(currNumber))
                {
                    numbers.Add(currNumber, 0);
                }

                numbers[currNumber]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
