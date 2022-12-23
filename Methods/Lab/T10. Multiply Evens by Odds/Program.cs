using System;
using System.Linq;

namespace T10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int absValues = Math.Abs(int.Parse(input));

            int result = GetMultipleOfEvenAndOdds(absValues.ToString());
            Console.WriteLine(result);           
        }
        static int GetMultipleOfEvenAndOdds(string input)
        {
            int result = GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);
            return result;
        }
        static int GetSumOfEvenDigits(string input)
        {
            int sumOfEvenDigits = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNumber = Math.Abs(int.Parse(input[i].ToString()));
                if (currNumber % 2 == 0)
                {
                    sumOfEvenDigits += currNumber;
                }
            }
            return sumOfEvenDigits;
        }
        static int GetSumOfOddDigits(string input)
        {
            int sumOfOddDigits = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNumber = Math.Abs(int.Parse(input[i].ToString()));
                if (currNumber % 2 != 0)
                {
                    sumOfOddDigits += currNumber;
                }
            }
            return sumOfOddDigits;
        }
    }
}
