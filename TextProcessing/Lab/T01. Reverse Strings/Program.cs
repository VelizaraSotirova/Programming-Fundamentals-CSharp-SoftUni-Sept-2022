using System;
using System.Text;

namespace T01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedText = new string(charArray);
                Console.WriteLine($"{input} = {reversedText}");

                input = Console.ReadLine();
            }
        }
    }
}
