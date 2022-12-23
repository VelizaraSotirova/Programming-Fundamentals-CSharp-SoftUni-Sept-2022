using System;

namespace T08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = GetPoweredNumber(baseNum, power);
            Console.WriteLine(result);
        }

        static double GetPoweredNumber(double baseNum, double power)
        {
            return Math.Pow(baseNum, power);
        }
    }
}
