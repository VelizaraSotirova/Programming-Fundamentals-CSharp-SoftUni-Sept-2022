using System;

namespace T02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copyNum = num;
            int sum = 0;

            while (copyNum > 0)
            {
                int lastDigit = copyNum % 10;
                sum += lastDigit;
                copyNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
