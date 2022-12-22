using System;

namespace T05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());

            for (int i = startOfInterval; i <= endOfInterval; i++)
            {
                char ch = (char)i;
                Console.Write(ch + " ");
            }
        }
    }
}
