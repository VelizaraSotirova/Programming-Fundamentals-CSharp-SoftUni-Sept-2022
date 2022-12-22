using System;

namespace T05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                }

                switch (sumOfDigits)
                {
                    case 5:
                    case 7:
                    case 11:
                        Console.WriteLine($"{num} -> True");
                        break;
                    default:
                        Console.WriteLine($"{num} -> False");
                        break;
                }
            }
        }
    }
}
