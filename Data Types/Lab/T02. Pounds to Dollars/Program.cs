using System;

namespace T02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPound = double.Parse(Console.ReadLine());
            double USDollars = britishPound * 1.31;
            Console.WriteLine($"{USDollars:f3}");
        }
    }
}
