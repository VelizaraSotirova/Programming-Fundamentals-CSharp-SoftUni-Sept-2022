using System;

namespace T03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(keyWord))
            {
                int startIndex = text.IndexOf(keyWord);
                text = text.Remove(startIndex, keyWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
