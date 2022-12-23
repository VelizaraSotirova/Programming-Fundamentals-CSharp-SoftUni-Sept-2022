﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrays = Console.ReadLine()
                .Split('|')  
                .ToList();

            var result = new List<int>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                result.AddRange(arrays[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse));
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
