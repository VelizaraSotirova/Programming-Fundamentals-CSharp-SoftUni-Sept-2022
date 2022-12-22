using System;

namespace T07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int waterPour = 0;

            for (int i = 0; i < n; i++)
            {
                waterPour = int.Parse(Console.ReadLine());
                sum += waterPour;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= waterPour;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
