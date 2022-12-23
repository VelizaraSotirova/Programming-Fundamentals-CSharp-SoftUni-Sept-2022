using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();
            int n = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < n; i++)
            {
                newList.Add(firstList[i]);
                newList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = n; i < firstList.Count; i++)
                {
                    newList.Add(firstList[i]);
                }
            }
            else if (secondList.Count > firstList.Count)
            {
                for (int i = n; i < secondList.Count; i++)
                {
                    newList.Add(secondList[i]);
                }
            }

            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
