using System;
using System.Numerics;

namespace T05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstInteger = BigInteger.Parse(Console.ReadLine());
            short secondInteger = short.Parse(Console.ReadLine());

            BigInteger product = firstInteger * secondInteger;
            Console.WriteLine(product);
        }
    }
}
