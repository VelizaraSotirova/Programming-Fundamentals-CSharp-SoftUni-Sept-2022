using System;

namespace T12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isSpecial = true;

            for (int ch = 1; ch <= number; ch++)
            {
                int sum = 0;
                int digit = ch;
                
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                if ((sum == 5) || (sum == 7) || (sum == 11))
                { 
                    Console.WriteLine("{0} -> {1}", ch, isSpecial); 
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", ch, !isSpecial);
                }
            }

        }
    }
}
