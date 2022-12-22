using System;
using System.Numerics;

namespace T11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger highestSnowballValue = BigInteger.MinusOne;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuantity = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuantity = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {highestSnowballValue} ({maxQuantity})");
        }
    }
}
