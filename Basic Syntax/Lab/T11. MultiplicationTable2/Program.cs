using System;

namespace T11._MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            for (int times = multiplier; times <= 10; times++)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
            }
            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
        }
    }
}
