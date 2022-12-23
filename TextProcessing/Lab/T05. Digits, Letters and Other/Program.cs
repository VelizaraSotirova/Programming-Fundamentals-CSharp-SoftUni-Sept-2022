using System;
using System.Text;

namespace T05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            char[] sequenceAsChar = sequence.ToCharArray();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            foreach (char item in sequenceAsChar)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    others += item;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
