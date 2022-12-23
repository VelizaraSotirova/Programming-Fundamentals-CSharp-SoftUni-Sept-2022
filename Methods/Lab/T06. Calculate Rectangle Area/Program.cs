using System;

namespace T06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(sideA, sideB);
            Console.WriteLine(area);
        }
        static double GetRectangleArea(double sideA, double sideB)
        {
            double area = sideA * sideB;
            return area;
        }
    }
}
