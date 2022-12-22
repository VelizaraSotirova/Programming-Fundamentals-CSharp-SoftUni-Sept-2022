using System;

namespace T10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char singleCharacter = char.Parse(Console.ReadLine());

            switch (singleCharacter)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    Console.WriteLine("upper-case");
                    break;
                default:
                    Console.WriteLine("lower-case");
                    break;
            }
        }
    }
}
