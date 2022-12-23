using System;

namespace T06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousChar = input[0];
            Console.Write(previousChar);

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar != previousChar)
                {
                    previousChar = currChar;
                    Console.Write(previousChar);
                }
            }
        }
    }
}
