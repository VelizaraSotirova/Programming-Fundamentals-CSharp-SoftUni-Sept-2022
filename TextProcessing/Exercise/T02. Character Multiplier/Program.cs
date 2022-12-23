using System;

namespace T02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            GetStringSum(input[0], input[1]);
        }

        private static void GetStringSum(string firstString, string secondString)
        {
            int sum = 0;
            int minLength = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            string maxLength = firstString;
            if (firstString.Length < secondString.Length)
            {
                maxLength = secondString;
            }

            for (int i = minLength; i < maxLength.Length; i++)
            {
                sum += maxLength[i];
            }

            Console.WriteLine(sum);
        }
    }
}
