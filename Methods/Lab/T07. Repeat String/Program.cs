using System;

namespace T07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());

            string result = StringRepeat(text, timesToRepeat);
            Console.WriteLine(result);
        }
        static string StringRepeat(string text, int timesToRepeat)
        {
            string result = string.Empty;

            for (int j= 0; j < timesToRepeat; j++)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    result += text[i];
                }
            }

            return result;
        }
    }
}
