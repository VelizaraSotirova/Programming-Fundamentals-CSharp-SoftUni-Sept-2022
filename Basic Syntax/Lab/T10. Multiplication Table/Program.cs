using System;

namespace T10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{n} X {times} = {n*times}");
            }
        }
    }
}
