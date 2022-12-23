using System;

namespace T04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var currBannedWord in bannedWords)
            {
                text = text.Replace(currBannedWord, new string('*', currBannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
