using System;

namespace T03._Passed_or_Failed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else if (grade < 3.00)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
