using System;
using System.Linq;

namespace T07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool areEqual = true;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];

                if (array1[i] != array2[i])
                {
                    areEqual = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
