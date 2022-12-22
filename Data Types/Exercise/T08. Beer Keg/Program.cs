using System;
using System.Numerics;

namespace T08._Beer_Keg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestBeer = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = (Math.PI * radius * radius * height);

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestBeer = model;
                }
            }

            Console.WriteLine(biggestBeer);
        }
    }
}
