using System;
using System.Linq;

namespace T03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNum;
                    secondArray[i] = secondNum;
                }
                else
                {
                    firstArray[i] = secondNum;
                    secondArray[i] = firstNum;
                }
            }

            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
