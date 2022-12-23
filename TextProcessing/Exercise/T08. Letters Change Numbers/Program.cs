using System;

namespace T08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1]; // ^1 == item.Length - 1

                string numberAsString = item[1..^1]; // between item[0] and item[item.Length - 1]
                double numberFromStringToDouble = double.Parse(numberAsString);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfLetter = firstLetter - 64;
                    numberFromStringToDouble /= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = firstLetter - 96;
                    numberFromStringToDouble *= positionOfLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfLetter = lastLetter - 64;
                    numberFromStringToDouble -= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = lastLetter - 96;
                    numberFromStringToDouble += positionOfLetter;
                }

                sum += numberFromStringToDouble;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
