using System;

namespace T03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string neededSubstring = input[input.Length - 1];
            string[] splittedSubstring = neededSubstring.Split(".", StringSplitOptions.RemoveEmptyEntries);

            string fileName = splittedSubstring[0];
            string fileExtension = splittedSubstring[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
