using System;

namespace T04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumberInpit = int.Parse(Console.ReadLine());

            for (int i = 0; i <= maxNumberInpit; i++)
            {
                PrintLine(1, i);
            }
            for (int j = maxNumberInpit - 1; j >= 1; j--)
            {
                PrintLine(1, j);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
