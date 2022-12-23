using System;
using System.Linq;

namespace T02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = Vowels(input);

            Console.WriteLine(vowelsCount);
        }
        static int Vowels(string input)
        {
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y'};
            int vowelsCount = 0;

            foreach (char letter in input.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
