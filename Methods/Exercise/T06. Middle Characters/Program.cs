using System;

namespace T06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string middleChars = MiddleChars(text);

            Console.WriteLine(middleChars);
        }

        static string MiddleChars(string text)
        {
            string result = string.Empty;

            if (text.Length % 2 == 0)
            {
                var len = (text.Length / 2) - 1;
                result = string.Concat(text[len], text[len + 1]);
            }
            else
            {
                var len = text.Length / 2;
                result = text[len].ToString();
            }

            return result;
        }
    }
}
