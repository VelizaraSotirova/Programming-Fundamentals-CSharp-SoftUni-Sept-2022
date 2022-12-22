using System;

namespace T06.StrongNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copyNum = num;
            int factorialSum = 0;

            while (copyNum > 0)
            {
                int lastDigit = copyNum % 10;
                copyNum /= 10;
                int factorial = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }

            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
