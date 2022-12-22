using System;

namespace T09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;

            for (int i = 1; i <= n * 2; i+=2)
            {
                Console.WriteLine(i);
                oddSum += i;
            }
            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
